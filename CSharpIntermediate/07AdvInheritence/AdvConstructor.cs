using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._07AdvInheritence
{
    //Base class constructor always executes first
    //Base class constructors are not inherited

    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being init");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }

    public class Car : Vehicle
    {
        //if the base class do not have a parameter less constructor, this will not compile.
        // to solve this we use base keyword that is used to run the parameterized constructor of the base class
        // with this the compiler will know that it has to run the base class constructor with the given parameter and then come to derieved class.
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"Car is being init {registrationNumber}");
        }
    }

    internal class AdvConstructor
    {
        static void Main(string[] args)
        {
            var car = new Car("BR01"); // will execute base class vehicle constructor first and then the Car class constructor.
        }
    }
}
