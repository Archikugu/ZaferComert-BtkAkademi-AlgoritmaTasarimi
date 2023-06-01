using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
    public class SWTC02
    {
        public static void SwitchCase02()
        {
            Random random = new Random();

            int caseSwitch = random.Next(1, 4);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Beklenmeyen Durum {caseSwitch}");
                    break;
            }
        }
    }
}
