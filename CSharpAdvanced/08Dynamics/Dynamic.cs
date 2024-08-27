using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._08Dynamics
{

    //Programming langueages are of 2 types -
    // Statically typed languages - C#, Java - Type resolution -> at compile time -> if a method is not defined in a object, you will get an error at compile time itself.
    // Dynamically typed language - Ruby, JS, Python - Type resolution -> at run time -> easier and faster to code.

    //C# -> started as a static language
    // .NET 4 added the dynamic capability to improve interoperability with COM(writing office applications) and dynamic languages like IronPython.

    //Reflection -> used in absense of dynamics -> is a way to inspect metadata about a type and access properties and methods.
    internal class Dynamic
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            obj.GetHashCode(); //dynamic


            //reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);


            //for ex
            object reflectionObj = "Reflection";
            //reflectionObj.Optimize(); // will give error as object class does not have a method named optimize and will fail at compile

            // to tackle this we can use dynamic
            dynamic exObj = "Dynamic";
            exObj.Optimize();

            //this is taken care by DLR(Dynamic Language Runtime) which sits on top of CLR that does the magic.
        }
    }
}
