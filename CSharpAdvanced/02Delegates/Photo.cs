using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._02Delegates
{
    internal class Photo
    {
        public void Load(string path)
        {
            Console.WriteLine($"path : {path}");
        }
    }
}
