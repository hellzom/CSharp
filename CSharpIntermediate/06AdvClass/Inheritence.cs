using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._06AdvClass
{
    //to achieve loosly coupled classes -> Encapsulation, The relationship b/w classess, interfaces
    //---------------------------------------------------------------------------------------------------

    //Inheritence -> A kind of relationship b/w two classess that allows one to inherit code from the other.
    //Is-A relationship -> A car is a vehicle
    //Code-Reuse
    //Object class is parent of all classes in C#.
    //withot even defining object class as parent class of any class, it'd be automatically defined and hence can access propertied of it such as hashmap.
    //Limitations of Inheritence ->
    //Easily abused by amateur designers
    //Large Hierarchies
    //Fragile Code
    //Tightly Coupled


    //Parent Class/Super Class
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was Duplicated");
        }
    }

    //Child Class/Derieved Class
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine($"We added a link to {url}");
        }
    }

    //use
    public class Inheritence
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Height = 100;
            text.AddHyperLink("sdfsd");
        }

    }
}
