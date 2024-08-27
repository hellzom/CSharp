namespace CSharpAdvanced._02Delegates
{
    public class PhotoProcessor
    {
        //System.Action<> -> Points to a function that returns void, can accept upto 1-16 parameters.
        //System.Func<out TResult> -> Points to a function that returns a value, can accept upto 1-16 parameters.

        //public delegate void PhotoFilterHandler(Photo photo);
        
        public void Process(string path, Action<string> filterHandler)
        {
          
            //var photo = Photo.Load(path);
            //filterHandler(photo);
           
            //photo.Save();
        }
    }
}
