using System;
using System.Text;

namespace Module2_Task1
{
    internal class Logger
    {
        private static readonly Logger Instance = new Logger();

        private StringBuilder _log = new StringBuilder("Program Log:/\n");

        private DateTime _time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
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
            string log = _time.ToString() + " : " + type.ToString() + " : " + message + "\n";
            Console.Write(log);
            _log.Append(log);
        }

        public void LogToFile()
        {
            System.IO.File.WriteAllText("log.txt", _log.ToString());
        }
    }
}
