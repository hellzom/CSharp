// See https://aka.ms/new-console-template for more information

namespace Interface
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)//implementing the methods defined in ILogger interface
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }
}