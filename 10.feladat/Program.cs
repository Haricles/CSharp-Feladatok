/* 
Készíts egy programot, amely a felhasználó által megadott egész számról eldönti, hogy
- csak 3-mal osztható,
- csak 4-gyel osztható,
- 3-mal és 4-gyel is osztható,
- sem 3-mal, sem 4-gyel nem osztható!
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
            int bekert_szam = Convert.ToInt32(Console.ReadLine());
            if (bekert_szam % 3 == 0)
            {
                Console.WriteLine("Ez a szám 3-al osztható!");

            }
            else if ( bekert_szam % 4 == 0)
            {
                Console.WriteLine("Ez a szám 4-al osztható!");
            }
            else if (bekert_szam % 4 == 0 && bekert_szam % 3 == 0)
            {
                Console.WriteLine("Ez a szám 3-al és 4-el is osztható!");
            }
            else
            {
                Console.WriteLine("Ez a szám nem oszható se 3-al se 4-el!");
            }
            Console.ReadKey();
        }
    }
}