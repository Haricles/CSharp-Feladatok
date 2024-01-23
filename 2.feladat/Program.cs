/*
Készíts egy rövid programot, amely a felhasználótól bekéri a kör sugarát, és ennek alapján kiszámolja a kör kerületét és területét!
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
            Console.Write("Add meg a kör sugarát: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A kör kerülete: {2 * Math.PI * r} és a kört területe: {Math.Pow(r, 2) * Math.PI}");
            Console.ReadKey();
        }
    }
}
