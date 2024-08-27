// See https://aka.ms/new-console-template for more information
namespace CSharpIntermediate
{
    class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.X = y;
        }
        //Method Overloading
        public void Move (int x, int y) {
            this.X = x; this.Y = y;
        }
        public void Move(Point newLocation) {
            if (newLocation == null)
                throw new ArgumentNullException("newlocation");
            Move(newLocation.X, newLocation.Y);

            //or use like
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
        public void Move(Point newLocation, int speed) { }
    }

    class Weirdo
    {

        //ref modifier
        public void DoAWeirdThing(ref int a) // using the ref keyword will call by reference, hence changes to a will reflect in the original parameter too.
        {
            a++;
        }
        //usage
        //var a = 1; //value of this a will change too if ref is used.
        //weirdo.DoAWeirdThing(ref a);

        //out modifier
        public void MyMethod(out int a) // using the out modifier, we can send back value using the variable.
        {
            a = 12;
        }

        //usage
        //int a; // this will be populated from inside the method using the out modifier
        //Weirdo.MyMethod(Out a);
    }
}