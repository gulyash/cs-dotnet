using System;
using dotnetlab5.Baking;

namespace dotnetlab5
{

    class Program
    {
        static void Main(string[] args)
        {
            //создаем логгер, в аргументе указываем файл для записи, если ничего не указать - вывод  консоль
            var logger = new Logger<Customer>("log.txt");
            var bakLogger = new Logger<Bakery>("log.txt");
            logger.OnLog += Logger_OnLog; // подписываемся на событие логгера
            bakLogger.OnLog += Logger_OnLog;

            Bakery bakery = new Bakery(bakLogger);
            Customer customer = new Customer(bakery, logger);
            //calling a delegate
            customer.orderPowderBun("puff", "cream");
            //customer.TryWithAllFillings();
            //customer.FindFilling("nonexistent");
            //customer.FindFilling("Nutella");
            customer.TryFilling("nonexistent");
            customer.TryFilling("Nutella");
            //this uses anonymous function
            //customer.orderPieAnonymous("biscuit", "blackberry");
            //this uses lambda fuction
            //customer.orderPieLambda("yeast", "jam");

            Console.ReadLine();
        }

        private static void Logger_OnLog(System.IO.TextWriter writer, string text)
        {
            var time = DateTime.Now.ToString(" MM/dd/yyyy hh:mm:ss");
            writer.WriteLine(time+" "+text);
        }
    }
}