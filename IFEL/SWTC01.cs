using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
    public class SWTC01
    {
        public enum Renkler { Kırmızı, Yeşil, Mavi }
        public static void SwitchCase01()
        {
            Renkler r = (Renkler)(new Random()).Next(0, 3);

            switch (r)
            {
                case Renkler.Kırmızı:
                    Console.WriteLine("Renk Kırmızı");
                    break;
                case Renkler.Yeşil:
                    Console.WriteLine("Renk Yeşil");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk Mavi");
                    break;
                default:
                    Console.WriteLine("Renk Bilinmiyor");
                    break;
            }
        }
    }
}
