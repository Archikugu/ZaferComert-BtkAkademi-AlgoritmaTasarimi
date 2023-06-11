using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Daire
    {
        public const double pi = 3.14;
        /// <summary>
        /// Dairenin alanini hesaplama  
        /// </summary>
        /// <param name="r">YariCap</param>
        /// <returns>Alan Degeri</returns>
        public static double AlaniHesapla(double r)
        {
            return pi * r * r;
        }
    }
}
