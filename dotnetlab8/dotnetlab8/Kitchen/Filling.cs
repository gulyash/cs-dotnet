using System;

namespace dotnetlab8.Kitchen
{
    /// <summary>
    /// class describing a filling
    /// </summary>
    [Serializable]
    public class Filling : IComparable
    {
        public string name;

        /// <summary>
        /// filling constructor
        /// </summary>
        /// <param name="p"></param>
        public Filling(string p)
        {
            name = p;
        }

        public Filling() { 
        
        }

        public int CompareTo(object obj)
        {
            return name.CompareTo(((Filling)obj).name);
        }
    }
}