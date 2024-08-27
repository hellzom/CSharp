using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._05AccessModifiers
{
    public class Indexers
    {
        // Indexers-> A way to access elements in a class that represents a list of values.

    }

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    //usage
    //var cookie = new HttpCookie();
    //cookie["name"] = "Rishi";
    //Console.WriteLine(Cookie["name"]);
}
