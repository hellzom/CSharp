// See https://aka.ms/new-console-template for more information


using Amazonnnn;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Normal method
                Person p = new Person();
                p.Name = "Test";
                Console.WriteLine(p.Name);


                var customer = new Customer();
                customer.Name = "Test1";
                customer.Id = 99;

                var customer1 = new Customer(1);
                customer1.Name = "Test2";

                var customer2 = new Customer(2, "Rishi");


                //object initializers
                var person = new Person
                {
                    Name = "Rishi"
                };


                var point = new Point(10, 10);
                point.Move(20, 30); //method 1
                point.Move(new Point(70, 90));//method 2


                var calculator = new _03Methods.Calculator();
                calculator.Add(1, 2, 3, 4, 5, 6);
                calculator.Add(1, 2, 3, 4, 5, 6,7,8,9);

                var cust = new Customerr();
                Amazonnnn.



                //out use
                int number;
                var res = int.TryParse("a", out number); // if success, res will be set to true and converted number will be stored in number variable
                if (res)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("Fail");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            


        }
    }
}