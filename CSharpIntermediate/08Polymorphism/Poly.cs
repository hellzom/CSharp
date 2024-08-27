using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._08Polymorphism
{
    //Method Overriding -> Modifying the implementation of an inherited method.(Runtime Polymorphism)
    //Poly->Many | Morph-> Forms

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw() // use a virtual keyword if you want the method in base class to be changed in derieved classes.
        {
            //Old implementation
            Console.WriteLine("Draw a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw() // use a override keyword on the base class method whom you want to change
        {
            //New Implementation
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()// use a override keyword on the base class method whom you want to change
        {
            //New Implementation
            Console.WriteLine("Draw a Rectangle");
        }
    }

    internal class Poly
    {
    }
}
