using dotnetlab1.Baking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Pie:AbstractBaking
    {
        public Pie(string pastry, string filling)
        {
            Weight = 800;
            Pastry = pastry;
            Filling = filling;
            Console.WriteLine("A whole {0} g. of tasty PIE made of {1} with delicious {2} filling appeared. Hooray!", Weight, Pastry, Filling);
        }
    }
}
