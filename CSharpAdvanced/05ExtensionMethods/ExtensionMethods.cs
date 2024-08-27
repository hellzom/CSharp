using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._05ExtensionMethods
{
    internal class ExtensionMethods
    {

        //ExtensionMethods -> Allows us to add methods to an existing class without changing its source code or creating a new class that inherits from it.
        //Only will work if the namespace is same for both class.

        static void Main(string[] args)
        {
            string post = "lonnnnnng text";
            var shortenedPost = post.Shorten(5);

        }
    }

    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be 1 or larger");

            if(numberOfWords == 0) return "";
            var words = str.Split(' ');

            if (words.Length <= numberOfWords) return str;

            return string.Join(" ",words.Take(numberOfWords));
        }
    }
}
