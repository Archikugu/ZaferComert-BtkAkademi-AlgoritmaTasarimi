using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARS
{
    public class VARS05
    {
        public static void VAR()
        {
            var x = 23; // Implicity typed
            int y = 23; // Explicity typed

            string[] meyveler = { "Elma", "Armut", "Muz", "Üzüm", "Şeftali" };
            var meyve = from m in meyveler where m[0] == 'A' select m;

            foreach (var m in meyve)
            {
                Console.WriteLine(m);
            }
        }
    }
}
