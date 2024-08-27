// See https://aka.ms/new-console-template for more information

namespace Interface
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}