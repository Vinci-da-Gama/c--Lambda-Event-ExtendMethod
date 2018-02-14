using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Event_ExtendMethod_Pj.EventClasses
{
    internal class MessageService
    {
        internal void OnVideoEncoded(object source, VideoEventArgs vo)
        {
            string vn = vo.VideoInEvent.Title;
            Console.WriteLine($"Message Service sends Text Message about video: {vn}.");
        }
    }
}
