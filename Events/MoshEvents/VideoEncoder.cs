using System;
using System.Threading;
using System.Threading.Tasks;

namespace MoshEvent
{
    public class VideoEncoder
    {
        //Separate delegate we use if we are sending parameter other than (object source, VideoEventArgs args)
        //because EventHandler having (object source, VideoEventArgs args)
        //public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodeEventHandler VideoEncoded;

        //We can do this simpler by using pre defined delegates :
        //EventHandler : Non-Generic Form
        //EventHandler<TEventArgs> : Generic Form

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            onVideoEncoded(video);
        }

        protected virtual void onVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });

        }
    }
}
