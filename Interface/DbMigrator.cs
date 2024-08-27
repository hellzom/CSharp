// See https://aka.ms/new-console-template for more information

namespace Interface
{
    public class DbMigrator
    {
        private readonly ILogger _logger; //Interface is defined as an private field(as learned in composition.
        public DbMigrator(ILogger logger) //dependency injection
        {
            _logger = logger; //here _logger which is object of Ilogger interface will receieve the object of the actual class that will implement the logging function as this is the constructor for DbMigrator Class.
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");

            //Details about miugrating the db

            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
        }
    }
}