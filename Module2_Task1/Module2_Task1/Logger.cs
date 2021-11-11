using System;
using System.Text;

namespace Module2_Task1
{
    internal class Logger
    {
        private static readonly Logger Instance = new Logger();

        private StringBuilder _log = new StringBuilder("Program Log:/\n");

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger LoggerInstance
        {
            get { return Instance; }
        }

        public void PushToLog(LogType type, string message = "No massage")
        {
            string log = DateTime.Now.ToString() + " : " + type.ToString() + " : " + message + "\n";
            Console.Write(log);
            _log.Append(log);
        }

        public void LogToFile()
        {
            System.IO.File.WriteAllText("log.txt", _log.ToString());
        }
    }
}
