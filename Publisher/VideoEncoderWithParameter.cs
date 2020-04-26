using System;
using System.Threading;

namespace C_
{
    public class VideoEncoderWithParameter
    {
        // public delegate void VideoEncodedHandler(object source, VideoEventArgs args);
        // public event VideoEncodedHandler videoEncoded;

        public event EventHandler<VideoEventArgs> videoEncodedWithParameter;
        public void EncodeVideo(Video v){
            Console.WriteLine("Enconding Video: {0}", v.VideoName);
            Thread.Sleep(3000);
            Console.WriteLine("Video Encode Process Finished !!");
            OnVideoEncoded(v);
        }
        protected virtual void OnVideoEncoded(Video v)
        {
            if(videoEncodedWithParameter != null)
               videoEncodedWithParameter(this, new VideoEventArgs(){ VideoParameter = v });
        }
    }
}