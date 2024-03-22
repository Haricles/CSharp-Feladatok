/* 
Írj egy programot, amely kiírja a páros számokat 1 és 10 között!
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
            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i += 1;
            }
            Console.ReadKey();
        }
    }
}