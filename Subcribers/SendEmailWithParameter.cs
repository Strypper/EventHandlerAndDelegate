using System;

namespace C_
{
    public class SendEmailWithParameter
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("Sending the Email " + e.VideoParameter.VideoName);
        }
    }
}