using System;
using System.Threading;

namespace C_
{
    public class VideoEncoder
    {
        
        //public delegate void VideoEncodedHandler(object source, EventArgs args);
        //public event VideoEncodedHandler videoEncoded;

        //Or you can just use this instead
        public event EventHandler videoEncoded;
        public void EncodeVideo(Video v){
            Console.WriteLine("Enconding Video: {0}", v.VideoName);
            Thread.Sleep(3000);
            Console.WriteLine("Video Encode Process Finished !!");
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if(videoEncoded != null)
               videoEncoded(this, EventArgs.Empty);
        }
    }
}