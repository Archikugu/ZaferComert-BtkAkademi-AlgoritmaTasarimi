using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
    public class IFEL02
    {
        /// <summary>
        /// IF  ELSE bloklarının AND ve OR yapısı ile kullanımı
        /// </summary>
        public static void IFELSE02()
        {
            bool result = true;
            if (result)//True döner
            {
                Console.WriteLine("Sonuç 1");
            }
            else
            {
                Console.WriteLine("Sonuç 2");
            }

            int m = 9;
            int n = 7;
            int p = 5;
            if (m >= n && m >= p)
            {
                Console.WriteLine("En büyük m");
            }
            if (m > n && !(p > m))
            {
                Console.WriteLine("En büyük m");
            }
            if (m > n || m > p)
            {
                Console.WriteLine("m en küçük değil");
            }
            m = 4;
            if (!(m > n || m >= p))
            {
                Console.WriteLine("m artık en küçük");
            }
        }
    }
}
