using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.WriteLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.log();
            Console.WriteLine("Customer Added");
        }
    }

    class DatabaseLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Database logged!");
        }
    }

    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }   

    interface ILogger
    {
        void log();
    }
}
