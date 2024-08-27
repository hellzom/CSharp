using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._03Lambda
{
    //Lambda Expression -> An anonymous method which has no name, no access modifier and no return statement.
    //Use -> For convenience -> write less code and do more, code readability.



    internal class Lambda
    {
        static void Main(string[] args)
        {
            //normal method
            static int Square(int number)
            {
                return number * number;
            }

            //assigning to delegate
            Func<int, int> square = Square;

            //same code in lambda

            //number => number* number;
            Func<int, int> squarelambda = number => number * number; //Func<parameter,returnType>

            var res = squarelambda(9);
        }
    }
}
