using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARS
{
    public class VARS03
    {
        public static void Const1()
        {
            //const int c = 23;
            //staticler sabitler ile kullanılmaz !
            //Console.WriteLine(c);

            int sayi = 5;
            const int c1 = 3;
            Console.WriteLine(c1);

            const int c2 = 4 + 5; //Readonly
                                  // const int c3 = 5 + sayi; // Hata verir sabitler sabitlere katılabilir;)

            //const int c4;
            //c4 = 5; // sabitler oluşturulduğu yerde değeri verilmelidir !
        }
        readonly int c1; // Readonly sadece constructor yapıda kullanılabilir.
        public VARS03()
        {
            c1 = 3;
        }
    }
}
