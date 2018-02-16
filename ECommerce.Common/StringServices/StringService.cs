using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common.StringServices
{
   public static class StringService
    {
        public static string Trim(string text)
        {
            return text.Trim();
        }

        public static string Capitalize(string text)
        {
            var firstLetter = text.Substring(0, 1);
            firstLetter = firstLetter.ToUpper();

            var LetterArray = text.Split(' ').ToArray();
            var secondLetter = LetterArray[1].Substring(0,1).ToUpper();

            var secondLetterIndex = text.IndexOf(LetterArray[1].Substring(0,1));

            text=firstLetter + text.Substring(1,text.IndexOf(' ')) + "  " + secondLetter + text.Substring(secondLetterIndex+1, text.Length - (secondLetterIndex + 1));
            return text;

        }
    }
}
