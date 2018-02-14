using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Event_ExtendMethod_Pj.LambdaClasses
{
    internal class BookList
    {
        public List<Book> GetBooks()
        {
            return new List<Book> {
                new Book() { Title="bt0", Price=5 },
                new Book() { Title="bt1", Price=7 },
                new Book() { Title="bt2", Price=17 }
            };
        }
    }
}
