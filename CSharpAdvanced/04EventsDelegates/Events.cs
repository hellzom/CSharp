using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced._04EventsDelegates
{

    //Events -> A mechanism for communication b/w objects.
    //Used to build loosely coupled applications.
    //Helps in extending applications.

    //Steps for event
    //1. Define a delegate
    //2. Define an event based on delegate
    //3. Publish the event.

    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {//Publisher

        //Step 1
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args); //reference to a method


        //Step 2
        public event VideoEncoderEventHandler VideoEncoded; //event related to the delegate
        
        //using pre built delegate
        public event EventHandler<VideoEventArgs> VideoEncodeding;

        //Step 3
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null) VideoEncoded(this, new VideoEventArgs { Video = video});
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the video");
            Thread.Sleep(3000);
        }
    }

    public class VideoEventArgs : EventArgs // class to group all the events
    {
        public Video Video { get; set; }
    }
    public class MailService
    {//Subscriber
        public void OnVideoEncoded(object source, VideoEventArgs args)//method implementation that the delegate is pointing
        {
            Console.WriteLine($"MailService: Sending an email for {args.Video.Title}");
        }
    }

    public class MessageService
    {//Subscriber
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MessageService: Sending a text message for {args.Video.Title}");
        }
    }

    
    internal class Events
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//Subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;// no method call, just the pointer reference
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
