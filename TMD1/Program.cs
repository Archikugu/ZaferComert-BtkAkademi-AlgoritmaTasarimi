using System;

namespace TMD1
{
    public class Program
    {
        static void Main(string[] args)
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
            else
            {
                Console.WriteLine("Yanlış sayı girdiniz girilen sayı = {0}", n);
            }
        }
    }
}
