using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZLR
{
    public class Dizi
    {   /// <summary>
        /// Tek boyutlu dizi oluşturmak için kullanılan fonksiyon
        /// </summary>
        /// <param name="limit">Dizinin uzunluğunu belirtir</param>
        /// <returns>Belirtilen uzunlukta rastgele sayılardan olusmus diziyi döner</returns>
        public int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];
            Console.WriteLine("");
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random().Next(1, 100);
                Console.Write("{0,5} ", sayilar[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Dizinin en buyuk elamani: {0}", EnBuyuk(sayilar));
            Console.WriteLine("Dizinin en kucuk elamani: {0}", EnKucuk(sayilar));
            return sayilar;
        }

        /// <summary>
        /// Parametre olarak aldigi dizideki en buyuk elemanı döner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns></returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }

        /// <summary>
        /// Parametre olarak aldigi dizideki en küçük elemanı döner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns></returns>
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            return ek;
        }

        /// <summary>
        /// Parametre olarak aldigi dizinin aritmetik ortalamasını hesaplar ve döner
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Aritmetik Ortalama</returns>
        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;

            for (int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / X.Length;
        }
    }
}
