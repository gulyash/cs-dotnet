using System;
using dotnetlab3.Baking;
using dotnetlab3.Kitchen;

namespace dotnetlab3
{
    //using delegates
    delegate PowderBun GetPowderBunOperation(Pastry pastry, Filling filling);
   
    class Customer
    {
        Bakery bakery;
        Fridge fridge;
        public GetPowderBunOperation getPowderBun;

        //delegate
        public void orderPowderBun(string pastry, string filling) {
            PowderBun orderedPowderBun = getPowderBun(new Pastry(pastry), new Filling(filling));
            Console.WriteLine("Customer got a powder bun!");
        }

        public void TryWithAllFillings() {
            fridge.DoWithAllFillings(fridge.TryFilling);
        }

        /*
        public void orderPieAnonymous(string pastry, string filling) {
            //delegate with anonymous function
            GetPieOperation getPieDelegate = delegate (Pastry p, Filling f)
            {
                return bakery.pieBaker.bake(p, f);
            };
            Pie orderedPie = getPieDelegate(new Pastry(pastry), new Filling(filling));
            Console.WriteLine("Customer got a pie using anonymous function.");
        }

        //using lambda expression
        public void orderPieLambda (string pastry, string filling) {

            GetPieOperation lambdaPie = (p, f) =>
            {
                return bakery.pieBaker.bake(p, f);
            };

            Pie orderedPie = lambdaPie(new Pastry(pastry), new Filling(filling));
            Console.WriteLine("Customer got a pie using lambda function.");
        }
        */
        public Customer(Bakery place) {
            bakery = place;
            fridge = bakery.fridge;
            getPowderBun = new GetPowderBunOperation(bakery.powderBunBaker.bake);
        }
    }
}
