using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lambda_Event_ExtendMethod_Pj.EventClasses
{
    internal class VideoEndoder
    {
        public void Encode(Video v)
        {
            Console.WriteLine(string.Format("Encode video -- {0}...", v.Title));
            // hold 3 seconds, then start...
            Thread.Sleep(3000);
        }
    }
}
