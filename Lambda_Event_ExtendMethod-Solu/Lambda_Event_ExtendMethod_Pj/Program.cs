using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lambda_Event_ExtendMethod_Pj.LambdaClasses;
using Lambda_Event_ExtendMethod_Pj.EventClasses;

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
            vEncoder.Encode(OneVideo);


            Console.WriteLine("Pls press enter to quite...");
            while(Console.ReadKey().Key != ConsoleKey.Enter) {}
        }

        internal static int CalculateArea(int side)
        {
            return side*side;
        }

    }
}
