// See https://aka.ms/new-console-template for more information

using System.Numerics;
namespace Interface
{
    //A class can only have one super class but can have multiple interfaces.
    //A class do not inherits an interface, it implements an interface as interface does not have any implementation of its own.
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);


            //here whille creating the object of the class that is linked to the interface, we do pass the actual class that interface is going to use as it was described in the constructor.
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            //suppose now we want another type of logging as file writer.
            //for that we just have to implement a class with that functionality and the class will be linked to ILogger interface and then just pass that new filelogger in the creation of object for DbMigrator.
            //This is called Extension
            //Also known as OpenClosePrinciple(OCP) which means that a class is closed for modification and any new implentation of the class should be done via extension of the class.
            //Open for extension, closed for modification.
            var dbMigratorNew = new DbMigrator(new FileLogger("C://"));
            dbMigratorNew.Migrate();
        }
    }
}