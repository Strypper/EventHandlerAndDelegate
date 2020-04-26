using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Event with no Parameter

            Video v = new Video("Family Guy");
            var VE = new VideoEncoder();
            var SE = new SendEmail();
            var SS = new SendSMS();
            VE.videoEncoded += SE.OnVideoEncoded;
            VE.videoEncoded += SS.OnVideoEncoded;
            VE.EncodeVideo(v);


            //Event with Parameter
            Video v1 = new Video("Fuck you Peter");
            var VEP = new VideoEncoderWithParameter();
            var SEP = new SendEmailWithParameter();
            var SSP = new SendSMSWithParameter();
            VEP.videoEncodedWithParameter += SEP.OnVideoEncoded;
            VEP.videoEncodedWithParameter += SSP.OnVideoEncoded;
            VEP.EncodeVideo(v1);
        }
    }
}
