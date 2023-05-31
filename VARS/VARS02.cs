using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARS
{
    public static class VARS02
    {
        public static void BoxUnbox()
        {
            //Kutulama - boxing 
            int i = 23;
            object o = i;
            //object o = (object)i; //explicit boxing

            //Kutudan Çıkarma - Unboxing
            i *= 2; // i=i*2;
            i = (int)o; //cast

            Console.WriteLine("Değer türü: {0}", i);
            Console.WriteLine("Referans türü: {0}", o);
        }
    }
}
