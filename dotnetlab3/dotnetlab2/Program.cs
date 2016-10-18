using System;
using dotnetlab3.Baking;

namespace dotnetlab3
{

    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery();
            Customer customer = new Customer(bakery);
            //calling a delegate
            customer.orderPowderBun("puff", "cream");
            customer.TryWithAllFillings();
            bakery.fridge.FindFilling("nonexistent");
            bakery.fridge.FindFilling("Nutella");
            //this uses anonymous function
            //customer.orderPieAnonymous("biscuit", "blackberry");
            //this uses lambda fuction
            //customer.orderPieLambda("yeast", "jam");


            Console.ReadLine();
        }
    }
}