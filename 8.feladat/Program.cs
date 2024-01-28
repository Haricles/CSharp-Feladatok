/* 
Készíts egy programot, amely a felhasználótól bekér egy egész számot, majd megvizsgálja, hogy a megadott szám
- pozitív páros vagy
- negatív páratlan.
Az eredményről tájékoztatja a felhasználót.
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
            Console.WriteLine("Kérlek adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam > 0)
            {
                Console.WriteLine("Ez a szám pozitív!");
            }
            else if (szam < 0)
            {
                Console.WriteLine("Ez a szám negatív!");
            }
            else
            {
                Console.WriteLine("Ez a szám pontosan 0!");
            }
            Console.ReadKey();
        }
    }
}