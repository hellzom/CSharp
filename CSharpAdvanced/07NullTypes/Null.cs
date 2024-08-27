using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._07NullTypes
{
    //ValueTypes -> cannot be null
    internal class Null
    {
        static void Main(string[] args)
        {
            //DateTime date = null; //this won't be allowed

            //for this we define like this.
            Nullable<DateTime> datee = null;

            //more convenient way is
            DateTime? dateeee = null;

            Console.WriteLine(dateeee.GetValueOrDefault());// 1/01/001 - default value will be returned
            Console.WriteLine(dateeee.HasValue); //false as null is assigned
            Console.WriteLine(dateeee.Value); //exception -> as null is not assigned a value

            //Null coehesing operator ??
            DateTime date2 = dateeee ?? DateTime.Today; //means -> if dateeee has a valid value, assign that to date2 , if not -> assign today's date to date2.

            //ternary operator
            DateTime date3 = (dateeee!=null) ? dateeee.GetValueOrDefault() : DateTime.Today;
        }
    }


}
