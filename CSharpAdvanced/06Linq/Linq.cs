using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._06Linq
{

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Ado", Price = 5 },
                new Book() { Title = "Bdo", Price = 55 },
                new Book() { Title = "Cdo", Price = 555 },
                new Book() { Title = "Ddo", Price = 5555 },
                new Book() { Title = "Edo", Price = 55555 }
            };
        }
    }
    internal class Linq
    {
            //LINQ -> Language Integrated Query
            //Gives the capabilility to query objects.
            // You can query ->
            // 1. Objects in memory, ex- collections(LINQ to objects)
            // 2. Databases (LINQ to entities)
            // 3. XML(LINQ to XML)
            // 4. ADO.NET Data sets(LINQ to Data Sets)

            //book object

            //LINQ Extension Methods
            //book.Where(b => b.Price <10).OrderBy(b => b.Title).Select(b => b.Title);
            //these extension methods are provided by Linq and they are predicate methods with Func delegate, so lambda expression can be used.

            //LINQ Query Operators
            //var cheapbooks = from b in books where b.Price < 10 orderby b.Title select b;

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ extension methods
            var book = books.SingleOrDefault(b => b.Title == "Bdo");
            Console.WriteLine(book);
        }
        }
}
