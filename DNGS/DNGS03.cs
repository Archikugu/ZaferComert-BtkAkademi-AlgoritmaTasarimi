using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNGS
{
    public class DNGS03
    {
        public static void BindenSıfıraKadarBesinKatlarıVeKacAdetElemanOldugunuGoster()
        {
            int sayac = 0;
            for (int i = 1000; i >= 0; i -= 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }
            Console.WriteLine("\n\n Eleman Sayisi : {0}", sayac);
        }
    }
}
