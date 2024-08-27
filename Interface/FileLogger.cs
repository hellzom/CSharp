// See https://aka.ms/new-console-template for more information

namespace Interface
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true)) // using statement is used for the functions that are not implemented by the CLR so if anything unexpected happens, then CLR can close this streamwriter by disposing it.
            {
                streamWriter.Write($"{messageType} : {message}");
            }
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }
        
    }
}