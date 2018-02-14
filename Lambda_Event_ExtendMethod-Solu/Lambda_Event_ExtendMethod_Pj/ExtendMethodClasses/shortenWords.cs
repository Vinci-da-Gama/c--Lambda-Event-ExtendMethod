using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Event_ExtendMethod_Pj.ExtendMethodClasses
{
    public static class ShortenWords
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords <= 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than 0.");

            if (str.Length < numberOfWords)
                return str;

            string[] words = str.Split(' ');
            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
