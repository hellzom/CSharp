using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._08Polymorphism
{

    //Abstract Modifier -> Indicates that a class or a member is missing implementation.

    //Abstract member cannot contain implementation
    //If a member is decleared as abstract, the containing class should also be then decleared as abstract.
    //Derieved class must implement all the abstract members no matter how many.
    //Abstract classes cannot be instanciated, so no objects can be created for the base abstract class.

    public abstract class Shape1
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw(); // use abstract keyword if you want to implement the method in derieved classes. This method will have no implementation that why no body {}

        public void Copy()
        {
            Console.WriteLine("Copyy");
        }
    }

    public class Circle1 : Shape1
    {
        public override void Draw() // use a override keyword on the base class method whom you want to change
        {
            //New Implementation
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle1 : Shape1
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
    internal class Abstract
    {
    }
}
