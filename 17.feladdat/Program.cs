/* 
Írj egy programot, amely a felhasználó által meghatározott alkalommal írja ki a bekért szöveget!
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
            int szam = Convert.ToInt32(Console.ReadLine());
            string szoveg = Console.ReadLine();
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(szoveg);
            }
            Console.ReadKey();
        }
    }
}