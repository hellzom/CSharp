using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator
    {
        public int Divide(int num, int den) { return num / den; }
    }

    public class YoutubeException : Exception 
    {
        //custom exception
        public YoutubeException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }

    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //log
                throw new YoutubeException("Could not fetch video", ex);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Divide(1, 0);// will give Divide by zero exception
            var streamReader = new StreamReader(@"c//");
            try
            {
                var calcui = new Calculator();
                calcui.Divide(1, 0);// will give Divide by zero exception
                var content = streamReader.ReadToEnd(); //need to dispose this

                //can eleminate finally block by using stamement
                using (var reader = new StreamReader(content))
                {
                    var contentt = reader.ReadToEnd();
                }



                //manually throwing an exception
                throw new Exception("Oops");

            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Divide by Zero excep");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Arithmatic Excep");
            }
            catch (Exception ex)
            { // parent exception class for all exception
                Console.WriteLine($"Some error occured {ex}");
            }
            finally
            {
                //will be always executed no matter what.
                //scope of finally will be seperate than try
                streamReader.Dispose(); //disposed methods that CLR doesnot handle

                
            }
        }
    }
}
