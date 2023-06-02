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
