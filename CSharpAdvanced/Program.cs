// See https://aka.ms/new-console-template for more information
using CSharpAdvanced._02Delegates;

Console.WriteLine("Hello, World!");

namespace CSharpAdvanced
{

    
    class Program
    {
        static void Main(string[] args)
        {
            var processorrr = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;

            //processorrr.Process("photo.jpg", filterHandler);
        }
    }
}