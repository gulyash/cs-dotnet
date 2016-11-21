using System;
using dotnetlab6.Baking;
using dotnetlab6.Kitchen;

namespace dotnetlab6
{
    //using delegates
    delegate PowderBun GetPowderBunOperation(Pastry pastry, Filling filling);
   
    class Customer
    {
        Bakery bakery;
        Fridge fridge;
        public GetPowderBunOperation getPowderBun;
        Logger<Customer> logger;

        //delegate
        public void orderPowderBun(string pastry, string filling) {
            PowderBun orderedPowderBun = getPowderBun(new Pastry(pastry), new Filling(filling));
            if (logger!=null) {
                logger.Log("Customer got a powder bun!");
            }
        }

        /// <summary>
        /// Using Func and Action classes
        /// </summary>
        public void TryWithAllFillings() {
            fridge.DoWithAllFillings(fridge.TryFilling);
            if (logger != null)
            {
                logger.Log("Customer tasted all fillings!");
            }
        }

        public void TryFilling(string name) {
            fridge.TryFilling(new Filling(name));
        }

        public void FindFilling(string filling) {
            bakery.fridge.FindFilling(filling);
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
        public Customer(Bakery place, Logger<Customer> logger = null) {
            bakery = place;
            fridge = bakery.fridge;
            this.logger = logger;
            getPowderBun = new GetPowderBunOperation(bakery.powderBunBaker.bake);
        }
    }
}
