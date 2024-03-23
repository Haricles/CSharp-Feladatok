/* 
Írj egy programot, amely a felhasználótól páros számot kér be. Amennyiben a megadott szám páratlan, újra és újra megtörténik az adatbekérés mindaddig, amíg végül páros számot nem ad meg a felhasználó.
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
            int szam;
            do
            {
                Console.WriteLine("Kérem adjon meg egy páros számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam % 2 != 0)
                {
                    Console.WriteLine("Sajnos nem sikerült!Próbáld újra!");
                }
                else
                {
                    continue;
                }

            }
            while (szam % 2 != 0);
            Console.WriteLine("Gratulálok sikerült páros számot beírnod!");
            Console.ReadKey();
        }
    }
}