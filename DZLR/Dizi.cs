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
                sayilar[i] = new Random().Next(0, 100);
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
            if (toplam / X.Length == 0)
            {
                Console.WriteLine("Sonuç sonsuzdur 0 a bölüm vardır");
            }
            return toplam / X.Length;
        }
        /// <summary>
        /// Parametre olarak aldigi dizinin standart sapmasını hesaplar 
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Standart Sapma</returns>
        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalma = AritmetikOrtalama(X);
            double t = 0, f = 0;
            double std = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalma;
                t += Math.Pow(f, 2);
            }
            std = t / (X.Length - 1);
            std = Math.Sqrt(std);
            return std;

        }

        /// <summary>
        /// Dizideki tek sayıların sayısını döner
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuc : tek sayıların sayısını</returns>
        public int TekSayilarinSayisi(int[] X)
        {
            int tekSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tekSayilarinSayisi++;
                }
            }
            return tekSayilarinSayisi;
        }

        /// <summary>
        /// Dizideki çift sayıların sayısını döner
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuc : çift sayıların sayısını</returns>
        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftSayilarinSayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftSayilarinSayisi++;
                }
            }
            return ciftSayilarinSayisi;
        }
        /// <summary>
        /// Bir dizideki tek sayilardan yeni bir dizi olusturur.
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Tek sayılardan olusan diziyi temsil eder</returns>
        public int[] TekDiziOlustur(int[] X)
        {
            int[] tekDizi = new int[TekSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tekDizi[y] = X[i];
                    y++;
                }
            }
            return tekDizi;

        }
        /// <summary>
        /// Bir dizideki çift sayilardan yeni bir dizi olusturur.
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>çift sayılardan olusan diziyi temsil eder</returns>
        public int[] CiftDiziOlustur(int[] X)
        {
            int[] ciftDizi = new int[CiftSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }
            }
            return ciftDizi;

        }

        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("{0,3}", X[i]);
            }
            Console.WriteLine("");
        }
    }
}
