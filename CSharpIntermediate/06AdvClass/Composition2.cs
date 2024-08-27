using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._06AdvClass
{

    public class Animal
    {
        public int age;
        public void Eat()
        {
            Console.WriteLine("This can eat!");
        }
        public void Sleep()
        {
            Console.WriteLine("This can sleep");
        }
        public Animal()
        {
        
        }
    }

    public class Walkable
    {
        public void Walk()
        {
            Console.WriteLine("This can walk");
        }
    }

    public class Swimmable
    {
        public void Swim()
        {
            Console.WriteLine("This can swim");
        }
    }

    public class Dog
    {
        private readonly Animal _animal;
        private readonly Walkable _walkable;
        public Dog(Animal animal, Walkable walkable)
        {
            _animal = animal;
            _walkable = walkable;
        }
        public void prop()
        {
            Console.WriteLine(_animal.age);
            Console.WriteLine(_animal.Eat);
            Console.WriteLine(_animal.Sleep);
            Console.WriteLine(_walkable.Walk);
        }
    }

    public class Goldfish
    {
        private readonly Animal _animal;
        private readonly Swimmable _swimmable;
        public Goldfish(Animal animal, Swimmable swimmable)
        {
            _animal = animal;
            _swimmable = swimmable;
        }
        public void prop()
        {
            Console.WriteLine(_animal.age);
            Console.WriteLine(_animal.Eat);
            Console.WriteLine(_animal.Sleep);
            Console.WriteLine(_swimmable.Swim);
        }
    }
    public class Composition2
    {
        static void Main(string[] args) {
            var goldfish = new Goldfish(new Animal(), new Swimmable());
            goldfish.prop();

            var animal = new Animal();
            var walkable = new Walkable();
            var dog = new Dog(animal, walkable);
            dog.prop();
    }
}
