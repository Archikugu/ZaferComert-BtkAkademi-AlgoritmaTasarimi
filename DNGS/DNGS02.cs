using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNGS
{
    public class DNGS02
    {
        public static void KullanıcıdanAlınanSayınınTekVeCiftToplami()
        {
            Console.WriteLine("Lütfen değer giriniz :");
            int limit;
            limit = Convert.ToInt32(Console.ReadLine());

            int tekToplam = 0, ciftToplam = 0;

            Console.WriteLine("Tek sayilar");
            for (int i = 1; i <= limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i; // tekTolam = tekToplam + i;
            }

            Console.WriteLine("\n \n Çift sayilar");
            for (int i = 0; i <= limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i; // ciftToplam = ciftToplam + i;
            }
            Console.WriteLine("\n \n Tek toplam: {0,5} \n \n Çift toplam: {1,5}", tekToplam, ciftToplam);
        }
    }
}
