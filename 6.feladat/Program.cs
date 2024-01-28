/* 
Készíts egy programot, ami bekér egy számot a felhasználótól, majd kiírja, hogy a megadott szám páros-e vagy páratlan!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    class Program
    {
        static void Main()
        {
            Console.Write("Kérem adjon meg egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("Ez a szám páros!");
            }
            else
            {
                Console.WriteLine("Ez a szám páratlan!");
            }
            Console.ReadKey();
        }
    }
}