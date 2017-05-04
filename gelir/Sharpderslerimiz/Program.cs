using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpderslerimiz
{
    class Program
    {
        static void Main()
        {
            int gun_gelir, gun_sayi, brut_gelir;
            double faiz, net_gelir;

            Console.WriteLine("Gunluk geliri daxil edin: ");
            gun_gelir = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Gun sayini daxil edin: ");

            gun_sayi = Int32.Parse(Console.ReadLine());
            brut_gelir = gun_gelir * gun_sayi;

            if(brut_gelir >= 1000)
            {
                faiz = brut_gelir * 0.18;
            }
            else
            {
                faiz = brut_gelir * 0.04;
            }

            net_gelir = brut_gelir - faiz;
            Console.WriteLine("Faiz: " + faiz.ToString() + " " + "Net Gelir: " + net_gelir.ToString());
            Console.ReadLine();
        }
    }
}
