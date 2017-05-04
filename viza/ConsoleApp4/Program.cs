using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int g_viza, g_final;

            double netice;

            Console.WriteLine("viza daxil edin: ");
            g_viza = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final daxil edin: ");
            g_final = Convert.ToInt32(Console.ReadLine());

            netice = g_viza * 0.4 + g_final * 0.6;

            if(netice >= 45)
            {
                Console.WriteLine("kecdin");
            }
            else
            {
                Console.WriteLine("kecmedin");
            }
            Console.WriteLine("netice: " + netice.ToString());
            Console.ReadLine();
        }
    }
}
