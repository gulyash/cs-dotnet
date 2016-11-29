using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using dotnetlab8.Serialization;

namespace dotnetlab8.Kitchen
{
    /// <summary>
    /// class describing a fridge. Contains different fillings
    /// </summary>
    [Serializable]
    public class Fridge : IEnumerable<Filling>, ICollection<Filling> //supporting interfaces ICollection & IEnumerable
    {
        /// <summary>
        /// filling collection
        /// </summary>
        public List<Filling> fillingShelf = new List<Filling>();

        /// <summary>
        /// название файла конфигурации
        /// </summary>
        [NonSerialized]
        public string fileName = "numconfig.txt";
    
        
        public Fridge() {   }

        /// <summary>
        /// Fills a fridge with a shelf of baking fillings
        /// </summary>
        public void FillFridgeByFile() {
            //using standart exceptions
            StreamReader sr = new StreamReader(fileName, System.Text.Encoding.Default);
            int num = Int32.Parse(sr.ReadLine());
            FillFridge(num);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public void FillFridge(int num) {
            FillingsGenerator gen = new FillingsGenerator();
            fillingShelf = gen.generateFillings(num);
        }

        /// <summary>
        /// displays sorting progress on console
        /// </summary>
        /// <param name="progress"></param>
        public static void SortProgress(int progress)
        {
            Console.Write("\rSorting: {0}%", progress);
        }

        /// <summary>
        /// асинхронная сортировка 
        /// </summary>
        /// <param name="fillings"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public async Task SortAsyncTask(List<Filling> fillings, IProgress<int> progress)
        {
            await Task.Run(() =>
            {
                List<Filling> sortedFillings = SortSyn(fillings, progress);
                fillings = sortedFillings;
            });
            Console.WriteLine("\nNailed it!");
        }
        
        public List<Filling> SortSyn(List<Filling> fillings, IProgress<int> progress) {
            var lastProg = -1;
            //remove the following condition
            for (var i = 0; i < fillings.Count - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < fillings.Count; j++)
                {
                    if (fillings[j].CompareTo(fillings[min]) < 0)
                    {
                        min = j;
                    }
                }
                var buf = fillings[i];
                fillings[i] = fillings[min];
                fillings[min] = buf;

                var prog = i * 100 / fillings.Count;
                if (prog != lastProg) // отчитываемся о прогрессе
                {
                    progress?.Report(prog);
                    lastProg = prog;
                }

            }
            progress?.Report(100);
            return fillings;
        }

        /// <summary>
        /// Do action with all items in fridge
        /// </summary>
        /// <param name="action">Action to do</param>
        public void DoWithAllFillings(Action<Filling> doWithOneFilling)
        {
            foreach (Filling filling in fillingShelf)
            {
                doWithOneFilling(filling);
            }
        }
        /// <summary>
        /// Action you can do with all items in fridge
        /// </summary>
        /// <param name="filling"></param>
        public void TryFilling(Filling filling) {
            //using user exception
            try {
                if (!this.hasFilling(filling.name)) throw new NoSuchFillingException(filling.name);
                Console.WriteLine("{0} filling is very tasty!", filling.name);
            }
            catch (NoSuchFillingException e) {
                Console.WriteLine("There is no {0} filling in the fridge!", e.name);
            }
        }

        /// <summary>
        /// Example func delegate to compare string with fillings in the fridge
        /// </summary>
        Func<Filling, string, int> func = (fill, searched) => fill.name.CompareTo(searched);

        /// <summary>
        /// Do func with all items in fridge
        /// </summary>
        /// <param name="st">String to find among titles</param>
        public void FindFilling(string toFind)
        {
            bool found = false;
            foreach (var filling in fillingShelf)
            {
                if (func(filling, toFind) == 0)
                {
                    Console.WriteLine("We actually have {0} filling, you should check it out!", toFind);
                    found=true;
                }
            }
            if (!found) Console.WriteLine("Sorry, we can't bake with {0} filling.", toFind);
        }

        /// <summary>
        /// checks if given filling is in the fridge
        /// </summary>
        /// <param name="str">name of a filling that you ask for</param>
        /// <returns>true if found this filling</returns>
        public Boolean hasFilling(string str)
        {
            Boolean exists = false;
            foreach (var filling in fillingShelf)
            {
                if (filling.name == str)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public IEnumerable<string> YieldFridge()
        {
            foreach (Filling f in fillingShelf)
            {
                yield return f.name;
            }
        }

        public void checkFridge() {
            Console.WriteLine("There are several fillings in the fridge:");
            foreach (string fillingName in YieldFridge()) {
                Console.WriteLine("{0}",fillingName);
            }
        }

        public IEnumerator<Filling> GetEnumerator()
        {
            return ((IEnumerable<Filling>)fillingShelf).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Filling>)fillingShelf).GetEnumerator();
        }


        public void Add(Filling item)
        {
            ((ICollection<Filling>)fillingShelf).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Filling>)fillingShelf).Clear();
        }

        public void CopyTo(Filling[] array, int arrayIndex)
        {
            ((ICollection<Filling>)fillingShelf).CopyTo(array, arrayIndex);
        }

        public bool Remove(Filling item)
        {
            return ((ICollection<Filling>)fillingShelf).Remove(item);
        }

        public bool Contains(Filling item)
        {
            return fillingShelf.Contains(item);
        }

        public int Count
        {
            get
            {
                return ((ICollection<Filling>)fillingShelf).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<Filling>)fillingShelf).IsReadOnly;
            }
        }

    }
}