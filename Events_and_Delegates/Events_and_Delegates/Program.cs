using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "Video 1"
            };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var msgService = new MessageService();//subscriber
           
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += msgService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }

    public class MailService {
        public void OnVideoEncoded(object source, EventArgs e) {
            Console.WriteLine("MailService: Sending an email...");
        }
    }

    public class MessageService{
        public void OnVideoEncoded(object source, EventArgs e) {
            Console.WriteLine("MessageService: Sending a text message...");
            
        }
    }
}
