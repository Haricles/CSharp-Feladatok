/* 
Készíts egy programot! A gép "gondol" egy számra 1 és 5 között, vagyis egy változóban tárolj egy ilyen számot! Azután a program bekér egy számot a felhasználótól, majd kiírja, hogy ez a szám egyenlő-e a gép által "gondolt" számmal, vagy annál kisebb, illetve nagyobb.
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
            Random veletlen = new Random();
            int veletlen_szam = veletlen.Next(1, 5);
            Console.WriteLine("Kérlek adj meg egy számot 1 és 5 között: ");
            int bekert_szam = Convert.ToInt32(Console.ReadLine());
            if (bekert_szam == veletlen_szam)
            {
                Console.WriteLine("Gratulálok! Nyertél!");
            }
            else if (bekert_szam > veletlen_szam)
            {
                Console.WriteLine("A megadott számod nagyobb mint a gondolt szám!");
            }
            else
            {
                Console.WriteLine("A megadott szám kisebb mint a gondolt szám!");
            }
            Console.ReadKey();
        }
    }
}