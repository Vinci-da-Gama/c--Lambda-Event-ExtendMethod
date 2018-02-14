using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Event_ExtendMethod_Pj.EventClasses
{
    internal class EmailService
    {
        internal void OnVideoEncoding(object source, VideoEventArgs vo)
        {
            string vn = vo.VideoInEvent.Title;
            Console.WriteLine($"Email Service sends email about video: {vn}.");
        }
    }
}
