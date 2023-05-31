using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARS
{
    public class Vars01
    {
        public static void Anakod()
        {
            int sayi = 23;
            sayi = sayi * 2;
            Console.WriteLine(sayi);

            int max, min;
            max = System.Int16.MaxValue;
            min = System.Int16.MinValue;

            Console.WriteLine("Int16 -> Min : {0} \t Max: {1}", min, max);

            int max32 = System.Int32.MaxValue;
            int min32 = System.Int32.MinValue;

            Console.WriteLine("Int32 -> Min : {0} \t Max: {1}", min32, max32);

            byte minByte = System.Byte.MinValue;
            byte maxByte = System.Byte.MaxValue;

            Console.WriteLine("Byte -> Min : {0} \t Max: {1}", minByte, maxByte);
        }
    }
}
