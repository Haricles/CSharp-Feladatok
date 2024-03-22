/* 
Írj egy programot, amely csökkenő sorrendben írja ki a számokat 1 és 10 között!
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
            for (int i =10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}