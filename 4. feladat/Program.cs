/* 
Készíts egy programot, amely megkérdezi a felhasználótól, hogy jó napja van-e! A válasz kétféle lehet: igen vagy nem. A választól függően írjon ki üzenetet a gép!
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
            Console.WriteLine("Jó napja van?");
            string valasz = Console.ReadLine();
            if ( valasz == "igen")
            {
                Console.WriteLine("Örülök,hogy jó napod van!");
            }
            else
            {
                Console.WriteLine("Sajnálom,hogy nincs jó napod!");
            }
            Console.ReadKey();
        }
    }
}