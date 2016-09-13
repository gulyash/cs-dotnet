using System;

namespace dotnetlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery();
            foreach(var baker in bakery.workers) {
                baker.bakeBun("jam");
                baker.bakePie("cream");
                baker.bakeBun("uranium");
                baker.bakePie("uranium");
            }
            Console.ReadLine();
        }
    }
}
