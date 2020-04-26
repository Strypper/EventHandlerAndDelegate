using System;

namespace C_
{
    public class SendSMSWithParameter
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("Sending the SMS " + e.VideoParameter.VideoName);
        }
    }
}