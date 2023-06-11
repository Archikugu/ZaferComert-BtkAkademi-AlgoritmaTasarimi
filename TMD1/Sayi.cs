using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Sayi
    {
        /// <summary>
        /// Paramtere olarak aldığı sayının tek mi yoksa çift olduğunu kontrol eder.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Tek ise true değilse false dönüş yapar</returns>
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Paramtere olarak aldığı sayının tek mi yoksa çift olduğunu kontrol eder.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>n değeri çift ise true değilse false dönüş yapar</returns>
        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parametre olarak aldigi sayinin mutlak degerini doner
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Girilen sayinin mutlak degeri dönüş ifadesi olacak</returns>
        public static int MutlakDeger(int n)
        {
            if (n > 0)
            {
                return n;
            }
            else if (n < 0)
            {
                return -1 * n;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Parametre olarak aldigi sayinin asal yada asal olmadığı degerini doner
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Girilen sayinin  degeri dönüş ifadesi olacak</returns>
        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük sayi 2'dir");
                return false;
            }
            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;

        }

        /// <summary>
        /// Parametre olarak aldigi sayinin rakamlari toplamı doner
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Rakamları toplamıdır</returns>
        public static int RakamlarToplamı(int n)
        {
            int toplam = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;

        }
        public static int NeKadarOlanSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t += i;
            }
            return t;
        }
        public static int NeKadarOlanSayilarinFormulToplami(int n)
        {
            return n * (n + 1) / 2;
        }

        public static int NeKadarOlanTekSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    t += i;
                }
            }
            return t;
        }
        public static int NeKadarOlanTekSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }
        public static int NeKadarOlanTekSayilarinFormulleToplami(int n)
        {
            n = n + 1;
            n = n / 2;
            return n * n;
        }

        public static int NeKadarOlanCiftSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    t += i;
                }
            }
            return t;
        }

        public static int NeKadarOlanCiftSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }

        public static int NeKadarOlanCiftSayilarinFormulleToplami(int n)
        {
            n = n / 2;
            return n * (n + 1);
        }
    }
}
