using System;

namespace TMD1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TekMiCiftMi();

            // MutlakDeger();
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
