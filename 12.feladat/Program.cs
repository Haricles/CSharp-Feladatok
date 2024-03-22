/* 
A program a pénzfeldobást modellezi. Kérdezze meg a felhasználótól a választását (fej vagy írás), majd adjon tájékoztatást, hogy eltalálta-e!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main()
        {
            Random random_szam = new Random();
            int szam = random_szam.Next(0, 2);
            Console.WriteLine("Fej vagy írás?");
            string bekert_szam = Console.ReadLine().ToLower();
            if (bekert_szam == "fej" && szam == 0)
            {
                Console.WriteLine($"Gratulálok eltaláltad! A te tipped {bekert_szam} és a gép pedig: {szam}");
            }
            else if (bekert_szam == "írás" && szam == 1)
            {
                Console.WriteLine($"Gratulálok eltaláltad! A te tipped {bekert_szam} és a gép pedig: {szam}");
            }
            else
            {
                Console.WriteLine($"Sajnos nem találtad el! A te tipped {bekert_szam} és a gép pedig: {szam}");
            }

            Console.ReadKey();
        }
    }
}