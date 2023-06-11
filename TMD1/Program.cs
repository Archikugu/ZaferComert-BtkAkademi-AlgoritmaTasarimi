﻿using System;

namespace TMD1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TekMiCiftMi();

            // MutlakDeger();

            // AsalMi();

            // RakamlarToplami();

            // NeKadarOlanSayılarınToplami();

            // NeKadarOlanSayilarınFormulIleToplami();

            // NeKadarOlanTekSayılarinToplami();

            // NeKadarOlanCiftSayılarinToplami();

            // AralıklıCiftSayilarinToplami();

            // CemberCevresi();

            // DaireninAlanı();

            Console.WriteLine("Dairenin yarı çapını Giriniz :");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dairenin açısını giriniz :");
            double aci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan = {0:F2}", Daire.AlaniHesapla(r, aci));

        }

        private static void DaireninAlanı()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan = {0:F2}", Daire.AlaniHesapla(r));
        }

        private static void CemberCevresi()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 * {0:F2} * {1:F2} = {2:F2}", Cember.pi, r, Cember.Cevresi(r));
        }

        private static void AralıklıCiftSayilarinToplami()
        {
            int t1 = Sayi.NeKadarOlanCiftSayilarinFormulleToplami(80);
            int t2 = Sayi.NeKadarOlanCiftSayilarinFormulleToplami(48);
            Console.WriteLine("{0,5} - {1,5} = {2,5}", t1, t2, t1 - t2);
        }

        private static void NeKadarOlanCiftSayılarinToplami()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinToplami(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanCiftSayilarinFormulleToplami(n));
        }

        private static void NeKadarOlanTekSayılarinToplami()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplami(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("{0}", Sayi.NeKadarOlanTekSayilarinFormulleToplami(n));
        }

        private static void NeKadarOlanSayilarınFormulIleToplami()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birden {0}'e kadar olan sayilarin toplami = {1,5}", n, Sayi.NeKadarOlanSayilarinFormulToplami(n));
        }

        private static void NeKadarOlanSayılarınToplami()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birden {0}'e kadar olan sayilarin toplami = {1,5}", n, Sayi.NeKadarOlanSayilarinToplami(n));
        }

        private static void RakamlarToplami()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayinin rakamlari toplami {1}", n, Sayi.RakamlarToplamı(n));
        }

        private static void AsalMi()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.AsalMi(n) ? "Asal sayi." : "Asal sayi değil!");
        }

        private static void MutlakDeger()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}| = {1} ", n, Sayi.MutlakDeger(n));
        }

        private static void TekMiCiftMi()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (Sayi.TekMi(n))
            {
                Console.WriteLine("Girilen sayi = {0} tek bir sayıdır!", n);
            }
            else if (Sayi.CiftMi(n))
            {
                Console.WriteLine("Girilen sayi = {0} çift bir sayıdır!", n);
            }
        }
    }
}
