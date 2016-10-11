using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1.Baking
{
    class Bun:AbstractBaking
    {
        public Bun(string pastry, string filling)
        {
            Weight = 300;
            Pastry = pastry;
            Filling = filling;
            Console.WriteLine("About {0} g. of tasty BUN made of {1} with delicious {2} filling appeared. Yay!", Weight, Pastry, Filling);   
        }
    }
}
