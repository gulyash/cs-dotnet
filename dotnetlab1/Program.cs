using dotnetlab1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery();
            bakery.yeastBaker.bakePie("blackberry");
            bakery.yeastBaker.bakeBun("cream");

            bakery.puffBaker.bakePie("cheese");
            bakery.puffBaker.bakeBun("chocolate");

            Console.ReadLine();
        }
    }
}
