using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
    public class IFEL01
    {
        public static void IFELSE01()
        {
            Console.WriteLine("Bir Karakter Giriniz: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter büyük bir karakterdir.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter küçük bir karakterdir");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter bir rakamdır");
            }
            else
            {
                Console.WriteLine("Karakter alfanumerik bir ifade değildir");
            }

        }
    }
}
