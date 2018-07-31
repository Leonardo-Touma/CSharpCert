using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDelegates
{
  
    public class videoEncoder
    {
        //1 - Define a delegate
        //2 - Define an event based on that delegate
        //3 - Raise the event
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(video video)
        {
            Console.WriteLine("Encoding video...!");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
