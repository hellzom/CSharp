using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate._07AdvInheritence
{

    //valuetype are stored in stack
    //short life

    //reference type stored in heap
    //more life
    //ex-class

    //Boxing -> The process of converting a value type to an object reference
    //Ex-> Object obj = 10;

    //Unboxing -> The process of converting a object reference back to value type.
    //Ex -> Object obj = 10;
    // int num = (int)obj; //will outpute 10

    //Performance penalty, avoid using.
    internal class BoxingUnboxing
    {
    }
}
