using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARS
{
    public class VARS04
    {
        public static void Const2()
        {
            var mC = new SampleClass(11, 22);
            Console.WriteLine($"x={mC.x}, y={mC.y}");
            Console.WriteLine($"C1 = {SampleClass.C1},C2={SampleClass.C2}");
        }
        class SampleClass
        {
            public int x;
            public int y;

            public const int C1 = 5;
            public const int C2 = C1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
    }
}
