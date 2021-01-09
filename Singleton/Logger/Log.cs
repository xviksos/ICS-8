using System;
using System.IO;

namespace Lab4Singleton.Logger
{
    internal class Log
    // Класс, в котором реализован Синглтон. Одиночка определяет статический метод getInstance, который возвращает единственный экземпляр своего класса.
    // Конструктор одиночки должен быть скрыт от клиентов.Вызов метода getInstance должен стать единственным способом получить объект этого класса.
    {
        private static Lazy<Log> log = new Lazy<Log>(() => new Log());

        private Log()
        {
        }

        // getInstance
        public static Log GetLog => log.Value;

        public void ExecuteLog(string message)
        {
            using var w = File.AppendText("log.txt");
            MakeLog(message, w);
            w.Close();
        }

        public static void MakeLog(string logMessage, TextWriter textWriter)
        {
            textWriter.Write("\r\nLog Entry : ");
            textWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            textWriter.WriteLine("Action: {0}", logMessage);
            textWriter.WriteLine("-------------------------------");
        }
    }
}