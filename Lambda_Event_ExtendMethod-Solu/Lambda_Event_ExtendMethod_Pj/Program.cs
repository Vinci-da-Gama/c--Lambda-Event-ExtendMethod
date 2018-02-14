using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lambda_Event_ExtendMethod_Pj.LambdaClasses;
using Lambda_Event_ExtendMethod_Pj.EventClasses;
using Lambda_Event_ExtendMethod_Pj.ExtendMethodClasses;

namespace Lambda_Event_ExtendMethod_Pj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Standard Method -- Area is : "+CalculateArea(5));

            Func<int, int> LambdaAreaHandler = (s) => s * s;
            Console.WriteLine("Delegate And Lambda -- Area is : " + LambdaAreaHandler(6));


            const int factor = 5;
            Func<int, int> Multipler = (n) => n * factor;
            int rz = Multipler(7);
            Console.WriteLine("Multipler rz: "+rz);


            BookList bl = new BookList();
            List<Book> books = bl.GetBooks();
            List<Book> cheaperBooks = books.FindAll((b) => b.Price < 10 );
            foreach (Book book in cheaperBooks)
            {
                Console.WriteLine(string.Format("This cheaper book is: {0} -- Price: {1}.", book.Title, book.Price));
            }


            // Events now...
            Video OneVideo = new Video() { Title = "VideoTitle_0" };
            VideoEndoder vEncoder = new VideoEndoder();
            EmailService es = new EmailService();
            MessageService ms = new MessageService();

            vEncoder.VideoEncodedEvent += es.OnVideoEncoding;
            vEncoder.VideoEncodedEvent += ms.OnVideoEncoded;

            vEncoder.Encode(OneVideo);

            // Extended Methods now...
            string aStr = "With silver footballs, icy-pole goal posts and circus acrobats, Australian rules' supercharged version AFLX has sceptics and traditionalists raising their eyebrows.";
            string shortenPost = aStr.Shorten(5);
            Console.WriteLine($"The short post is --> {shortenPost}");

            List<int> NumList = new List<int>() { 1,3,5,12,56,88,32,66 };
            int maxNum = NumList.Max();
            Console.WriteLine($"Max number is: {maxNum}.");

            Console.WriteLine("Pls press enter to quite...");
            while(Console.ReadKey().Key != ConsoleKey.Enter) {}
        }

        internal static int CalculateArea(int side)
        {
            return side*side;
        }

    }
}
