using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;

        //ctor->shortuct to create constructor

        //blank constructor
        public Customer() 
        {
            //always initalize the empty lists in constructor itself.
            Orders = new List<Order>();
        }

        //constructor with 1 argument
        public Customer(int id) : this() // inheriting the default constructor, so whenever this constructor will be called, it will first call the default constructor
        {
            this.Id = id;
        }

        //constructor with 2 argument
        public Customer(int id, string name) : this(id) // sameway it will first call the id constructor
        {
            this.Name = name;
            this.Id = id;
        }

    }
}
