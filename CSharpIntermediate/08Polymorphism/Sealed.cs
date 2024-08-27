using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._08Polymorphism
{
    //Sealed Modifier -> Prevents derivation of classes or overriding of methods.
    //Sealed classes are a bit faster

    public sealed class Shape2
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw() { }

        public void Copy()
        {
            Console.WriteLine("Copyy");
        }
    }

    public class Circle2 : Shape2
    {
        public override void Draw() // use a override keyword on the base class method whom you want to change
        {
            //New Implementation
            Console.WriteLine("Draw a circle");
        }
    }
    internal class Sealed
    {
    }
}
