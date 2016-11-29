using System;
using System.Collections.Generic;
using System.IO;
using dotnetlab8.Kitchen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8test
{
    [TestClass]
    public class FridgeTest
    {
        Fridge fridge = new Fridge();
        FillingsGenerator gen = new FillingsGenerator();

        [TestMethod]
        public void CountTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            Assert.AreEqual(fridge.Count, fridge.fillingShelf.Count);
            Assert.AreEqual(fridge.Count, 10);
            Assert.AreEqual(fridge.fillingShelf.Count, 10);
        }

        [TestMethod]
        public void ValidateConsoleOutputOnMethodTryFilling_SaysFillingIsTasty()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Filling fill = fridge.fillingShelf[1];

                fridge.TryFilling(fill);
                string expected = string.Format("{0} filling is very tasty!{1}", fill.name, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void ValidateConsoleOutputOnMethodTryFilling_SaysThereIsNoSuchFilling()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Filling fill = new Filling("nonexistent");

                fridge.TryFilling(fill);
                string expected = string.Format("There is no {0} filling in the fridge!{1}", fill.name, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void ValidateConsoleOutputOnMethodFindFilling_FoundFilling()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Filling fill = fridge.fillingShelf[1];

                fridge.FindFilling(fill.name);
                string expected = string.Format("We actually have {0} filling, you should check it out!{1}", fill.name, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void ValidateConsoleOutputOnMethodhasFilling_FoundFilling()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            String str = fridge.fillingShelf[0].name;
            Assert.IsTrue(fridge.hasFilling(str));
            Assert.IsFalse(fridge.hasFilling("nonexistent"));
        }


        [TestMethod]
        public void ValidateConsoleOutputOnMethodFindFilling_NotFoundFilling()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Filling fill = new Filling("nonexistent");

                fridge.FindFilling("nonexistent");
                string expected = string.Format("Sorry, we can't bake with {0} filling.{1}", fill.name, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FillFridgeByFileTest()
        {
            Fridge fridge = new Fridge();
            fridge.FillFridgeByFile();
            

            Assert.IsTrue(fridge.fillingShelf.Count > 0);
        }

        [TestMethod]
        public void DoWithAllFillingsTest()
        {
            Fridge fridge = new Fridge();
            fridge.FillFridge(2);
            fridge.DoWithAllFillings((Filling f)=> { f.name = "kek"; });
            Assert.IsTrue(fridge.fillingShelf[0].name=="kek");
        }

        [TestMethod]
        public void FillFridgeTest()
        {
            Fridge fridge = new Fridge();
            fridge.FillFridge(2);
            Assert.IsTrue(fridge.Count == 2);
        }

        [TestMethod]
        public void SortFridgeTest()
        {
            Fridge fridge = new Fridge();
            List<Filling> expected = new List<Filling> { new Filling("abab"), new Filling("baba") };
            List<Filling> toSort = new List<Filling> { new Filling("baba"), new Filling("abab") };
            toSort = fridge.SortSyn(toSort, new Progress<int>());
            Assert.AreEqual(toSort[0].name, expected[0].name);
        }

        [TestMethod]
        public void ValidateConsoleOutputOnMethodSortProgress()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Fridge.SortProgress(100);
                string expected = string.Format("\rSorting: 100%");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void checkFridgeTest()
        {
            Fridge fridge = new Fridge();
            fridge.fillingShelf.Add(new Filling("test"));

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                fridge.checkFridge();
                string expected = string.Format("There are several fillings in the fridge:{0}test{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void YieldTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(2);

            foreach (string fname in fridge.YieldFridge()) {
                Assert.IsTrue(fridge.hasFilling(fname));
            }

            
        }

        [TestMethod]
        public void EnumeratorTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);

            fridge.GetEnumerator();

            Assert.IsNotNull(fridge.fillingShelf);
        }

        [TestMethod]
        public void AddTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            Filling fill = new Filling("Сулейманов");
            fridge.Add(fill);

            Assert.IsTrue(fridge.hasFilling("Сулейманов"));
        }

        [TestMethod]
        public void ClearTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            fridge.Clear();

            Assert.AreEqual(fridge.fillingShelf.Count, 0);
        }

        [TestMethod]
        public void CopyToTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            Filling[] array = new Filling[100];
            fridge.CopyTo(array, 0);

            Assert.AreEqual(fridge.fillingShelf[0], array[0]);
        }

        [TestMethod]
        public void IsReadonlyTest()
        {
            Fridge fridge = new Fridge();
            Assert.IsTrue(fridge.IsReadOnly == ((ICollection<Filling>)fridge.fillingShelf).IsReadOnly);
        }

        [TestMethod]
        public void RemoveTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            Filling fill = fridge.fillingShelf[0];
            Assert.IsTrue(fridge.Remove(fill));
            Assert.IsFalse(fridge.Contains(fill));
            //Assert.IsTrue(fridge.Contains(fill) == fridge.fillingShelf.Contains(fill));
        }

        [TestMethod]
        public void ContainsTest()
        {
            Fridge fridge = new Fridge();
            FillingsGenerator gen = new FillingsGenerator();
            fridge.fillingShelf = gen.generateFillings(10);
            Filling fill = fridge.fillingShelf[0];
            Assert.IsTrue(fridge.Contains(fill));
            Assert.IsTrue(fridge.Contains(fill)==true);
            Assert.IsTrue(fridge.Contains(fill) == fridge.fillingShelf.Contains(fill)); 
        }


    }
}
