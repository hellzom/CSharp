using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._07AdvInheritence
{
    public class Shape
    {
        public int width {  get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw() { }
    }
    class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
    }

    
    internal class UpcastingDowncasting
    {

        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;//upcasting
            Text text1 = (Text)shape;//downcasting
        }
    }
}
