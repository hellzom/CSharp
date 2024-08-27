// See https://aka.ms/new-console-template for more information
namespace CSharpIntermediate
{
    //Class is a building block of an application
    //Class->Data(reperesented by fields) | Behaviour(represented by Functions/Methods)

    //Object is an instance of a class.
    //Basically Class is a blueprint of an object. Using a class many objects can be created.

    public class Person
    {
        public Person() { } // Constructor->should have the same name as class
        
        public string Name { get; set; }
        public Person(string name) //constructor with arguments ->to be used via constructor overloading.
        {
            this.Name = name; 
        }
    }
}