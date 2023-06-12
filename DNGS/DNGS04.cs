using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNGS
{
    public class DNGS04
    {
        public static void CarpimTablosu()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5} x {1,5} = {2,5}", i, j, i * j);
                }
                Console.WriteLine("\n\n ------------- \n\n");
            }
        }
    }
}
