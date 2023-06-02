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
    }
}
