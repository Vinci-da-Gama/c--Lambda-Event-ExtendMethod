using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lambda_Event_ExtendMethod_Pj.EventClasses
{
    internal class VideoEndoder
    {
        // public delegate void VideoEncodeEventHandler(object obj, VideoEventArgs ve);
        public event EventHandler<VideoEventArgs> VideoEncodedEvent;
        public void Encode(Video v)
        {
            Console.WriteLine(string.Format("Encode video -- {0}...", v.Title));
            // hold 3 seconds, then start...
            Thread.Sleep(3000);

            OnVideoEncoding(v);
        }

        protected virtual void OnVideoEncoding(Video v)
        {
            if (VideoEncodedEvent != null)
                VideoEncodedEvent(this, new VideoEventArgs() { VideoInEvent = v });
        }

    }
}
