using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._06AdvClass
{

    //Composition -> A kind of relationship b/w two classes that allows one to contain the other.
    //Has-A relationship -> Car has an Engine.
    //Flexible than inheritence -> loosely coupling
    // In this method, the classess are not inherited but are loosely coupled.
    // The inherited class is defined as an private field in the derieved class.

    //Any inheritence can be translated to composition.

    //Main class
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    //Classes having Logger class as an private field.
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Wer are migrating");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application");
        }
    }

    //Use
    public class Composition
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger()); //created the logger object while passing it as an argument

            dbMigrator.Migrate();

            var logger = new Logger();

            var installer = new Installer(logger); // created the logger object and then passed as an variable.

            installer.Install();
        }
    }

    
    
}
