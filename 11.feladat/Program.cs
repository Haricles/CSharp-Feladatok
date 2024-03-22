/* 
Készíts egy rövid programot, amely 1 és 3 között generál véletlenszámot, majd összehasonlítja ezt a felhasználó által megadott, szintén ebbe a tartományba eső számmal! Az összehasonlítás eredményéről tájékoztassa a felhasználót!
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
            Random szam = new Random();
            Console.WriteLine("Adj meg egy számot: ");
            int bekert_szam = Convert.ToInt32(Console.ReadLine());
            double random_szam = szam.Next(1,3);
            Console.WriteLine(random_szam);
            if (random_szam < bekert_szam)
            {
                Console.WriteLine("A random szám kisebb mint a bekeért szám!");
            }
            else if( random_szam> bekert_szam)
            {
                Console.WriteLine("A random szám nagyobb mint a bekért szám!");
            }
            else
            {
                Console.WriteLine("A random szám és a bekért szám egyenlő!");
            }
            Console.ReadKey();
        }
    }
}