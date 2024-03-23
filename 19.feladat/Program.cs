/* 
Írj egy programot, amely [1;12] intervallumon állít elő 20 darab véletlenszámot! A képernyőre kizárólag csak a 3-mal oszthatóakat írja ki, és a végén informálja a felhasználót arról is, hány darab ilyen szám volt.
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
            int szamlalo = 0;
            for(int i = 0; i < 20; i++)
            {
                int szam = random_szam.Next(1, 12);
                if (szam % 3 == 0)
                {
                    Console.WriteLine($"Hárommal oszható szám:{szam}");
                    szamlalo += 1;
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"Hárommal oszható szám:{szam}");
            }
            Console.WriteLine(szamlalo);

            Console.ReadKey();
        }
    }
}