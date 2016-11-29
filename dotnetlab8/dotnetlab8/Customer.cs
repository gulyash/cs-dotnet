using System;
using dotnetlab8.Baking;
using dotnetlab8.Kitchen;

namespace dotnetlab8
{
    //using delegates
    public delegate PowderBun GetPowderBunOperation(Pastry pastry, Filling filling);

    public class Customer
    {
        Bakery bakery;
        Fridge fridge;
        public GetPowderBunOperation getPowderBun;
        public PowderBun orderedPowderBun;

        Logger<Customer> logger;

        //delegate
        public void orderPowderBun(string pastry, string filling) {
            orderedPowderBun = getPowderBun(new Pastry(pastry), new Filling(filling));
        }
        
        public Customer(Bakery place, Logger<Customer> logger = null) {
            bakery = place;
            fridge = bakery.fridge;
            this.logger = logger;
            getPowderBun = new GetPowderBunOperation(bakery.powderBunBaker.bake);
        }
    }
}
