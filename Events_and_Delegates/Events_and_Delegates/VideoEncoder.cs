using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Events_and_Delegates
{
    class VideoEncoder
    {
        //1. Define a delegate
        //2. Define an event
        //3. Raise the event

        // A delegate holds a reference to a function in this case an event handler
        public delegate void VideoEncodedEventHandler(object source, EventArgs e);
       
        // the event based on the delegate
        public event VideoEncodedEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        //raise the event
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null) {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
