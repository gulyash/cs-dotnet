using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dotnetlab8.Logger;

namespace dotnetlab8
{
    public class Logger<T> : ILogger<T> //обобщенный класс для логирования
    {
        public string Path { get; set; }

        /// <summary>
        /// Конструктор логгера
        /// </summary>
        /// <param name="path">Путь к файлу с логами. Если null, вывод будет осуществлен на консоль</param>
        public Logger(string path=null)
        {
            Path = path; 
        }
        
        /// <summary>
        /// возвращает void
        /// </summary>
        public event Action<TextWriter,string> OnLog;

        private Object thisLock = new Object();

        public void Log(string Message)
        {
            Thread thread;

            thread = new Thread(() =>
            {
                if (OnLog != null)
                {

                    TextWriter writer;
                    writer = Path == null ? Console.Out : File.AppendText(Path);
                    var line = typeof(T).ToString() + ": " + Message;
                    //вызываем событие
                    OnLog(writer, line);
                    writer.Close();
                }
            });
            thread.Start();

            thread.Join();
        }
    }
}
