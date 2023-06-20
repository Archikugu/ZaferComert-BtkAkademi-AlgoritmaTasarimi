using System;
using System.Collections.Generic;

namespace DZLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DZLR01.Olustur();
            Console.WriteLine("n değerini giriniz: \n");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] X = new Dizi().Olustur(n);

            Console.WriteLine("Dizinin aritmetik ortalamasi : {0:F2}", Dizi.AritmetikOrtalama(X));

            Console.WriteLine("Dizinin standart sapmasi : {0:F2}", Dizi.StandartSapma(X));

            Dizi dizi = new Dizi();

            int[] tekSayilarDizisi = dizi.TekDiziOlustur(X);
            Dizi.Yazdir(tekSayilarDizisi);
            Console.WriteLine("Tek Sayıların Sayisi:{0,5}", dizi.TekSayilarinSayisi(X));

            int[] ciftSayilarDizisi = dizi.CiftDiziOlustur(X);
            Dizi.Yazdir(ciftSayilarDizisi);
            Console.WriteLine("Çift Sayıların Sayisi:{0,5}", dizi.CiftSayilarinSayisi(X));
        }


    }
}
