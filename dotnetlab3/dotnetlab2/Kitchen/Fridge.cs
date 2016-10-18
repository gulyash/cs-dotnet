using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetlab3.Kitchen
{
    /// <summary>
    /// class describing a fridge. Contains different fillings
    /// </summary>
    class Fridge : IEnumerable<Filling>, ICollection<Filling> //поддержка интерфейсов ICollection и IEnumerable
    {
        /// <summary>
        /// filling collection
        /// </summary>
        private List<Filling> fillingShelf = new List<Filling>();
    
        /// <summary>
        /// Puts a fridge with a shelf of baking fillings
        /// </summary>
        public Fridge()
        {
            Filling jamFill = new Filling("jam");
            fillingShelf.Add(jamFill);
            fillingShelf.Add(new Filling("blackberry"));
            fillingShelf.Add(new Filling("cheese"));
            fillingShelf.Add(new Filling("cream"));
            fillingShelf.Add(new Filling("caramel"));
            fillingShelf.Add(new Filling("yoghurt"));
            fillingShelf.Add(new Filling("Nutella"));

            //checking how ICollection works
            //if (fillingShelf.Contains(jamFill)) Console.WriteLine("CONTAINS");
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
            Console.WriteLine("{0} filling is very tasty!", filling.name);
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