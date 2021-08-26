using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface ILogger
    {
        bool Log(string value);
    }

    class XmlLog : ILogger
    {
        public bool Log(string value)
        {
            //
            //
            return true;
        }
    }
    class Logger
    {
        ILogger _logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string value)
        {
            _logger.Log(value);
        }
    }
    
}
