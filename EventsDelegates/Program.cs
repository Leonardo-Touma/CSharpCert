using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ownTest = new OwnTestOfDelegatesAndEvents();
            ownTest.Start();

            //Events = mechanism between objects
            var video = new video() { Title = "Video 1" };

            var videoEncoder = new videoEncoder();//Publisher

            var mailService = new MailService();//Subscriber
            var messageService = new MessageService();//Subscriber
            var soundService = new SoundService();
            videoEncoder.VideoEncoded += soundService.OnvideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.ReadKey();
        }
    }
   
}
