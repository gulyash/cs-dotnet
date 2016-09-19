using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetlab1
{
    /// <summary>
    /// Contains different fillings. It might happen that there is no such filling in the fridge
    /// </summary>
    class Fridge : IEnumerable
    {
        private List<Filling> fillingShelf= new List<Filling>();

        /// <summary>
        /// Puts a fridge with a shelf of baking fillings
        /// </summary>
        public Fridge()
        {
            fillingShelf.Add(new Filling("jam"));
            fillingShelf.Add(new Filling("blackberry"));
            fillingShelf.Add(new Filling("cheese"));
            fillingShelf.Add(new Filling("cream"));
            fillingShelf.Add(new Filling("yoghurt"));
            fillingShelf.Add(new Filling("Nutella")); 
        }
        /// <summary>
        /// checks if there is such filling available in the fridge
        /// </summary>
        /// <param name="str">Name of a filling to find</param>
        /// <returns></returns>
        public Boolean hasFilling(string str)
        {
            Boolean exists = false;
            foreach (var filling in fillingShelf)
            {
                if (filling.name == str) { 
                    exists = true; 
                    break; 
                }
            }
            return exists;
        }

        public IEnumerator GetEnumerator()
        {
            // Return the array object’s IEnumerator.
            return fillingShelf.GetEnumerator();
        }
    }
}