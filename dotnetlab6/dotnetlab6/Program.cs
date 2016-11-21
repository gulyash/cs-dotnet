using System;
using dotnetlab6.Baking;

namespace dotnetlab6
{

    class Program
    {
        static void Main(string[] args)
        {
            //создаем логгер, в аргументе указываем файл для записи, если ничего не указать - вывод  консоль
            //var logger = new Logger<Customer>();
            var bakLogger = new Logger<Bakery>("log.txt");
            //logger.OnLog += Logger_OnLog; // подписываемся на событие логгера
            bakLogger.OnLog += Logger_OnLog;

            Bakery bakery = new Bakery(bakLogger);
            Customer customer = new Customer(bakery);
            //calling a delegate
            //customer.orderPowderBun("puff", "cream");

            Console.ReadLine();
        }

        private static void Logger_OnLog(System.IO.TextWriter writer, string text)
        {
            var time = DateTime.Now.ToString(" MM/dd/yyyy hh:mm:ss");
            writer.WriteLine(time+" "+text);
            writer.Close();
        }
    }
}