using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetlab5.Logger
{
    interface ILogger<T>
    {
    /// <summary>
    /// Событие логирования
    /// </summary>
        event Action<TextWriter, string> OnLog;

    /// <summary>
    /// Выполняет логгирование заданного сообщения
    /// </summary>
    /// <param name="Message"></param>
        void Log(string Message);
    }
}
