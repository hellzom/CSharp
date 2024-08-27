using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._04Fields
{
    public class Fields
    {
        public int Id;
        public string Name;
        //initialize the fields while declearing
        public List<Ord> Ords = new List<Ord>();


        public Fields()
        {
            
        }
    }

    public class Ord { }
}
