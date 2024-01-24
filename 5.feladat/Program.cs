/* 
Készíts egy programot, amely megkérdezi a felhasználótól, hogy jó napja van-e! A válasz kétféle lehet: igen vagy nem. A választól függően írjon ki üzenetet a gép!
Fejleszd tovább az első feladat programját úgy, hogy amennyiben a felhasználó nem a két lehetséges válasz (igen/nem) közül ad meg egyet, a gép kiírja: "Sajnos nem értem a válaszodat!"
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
            string valasz = Console.ReadLine().ToLower();
            if ( valasz == "igen")
            {
                Console.WriteLine("Örülök,hogy jó napod van!");
            }
            else if (valasz == "nem")
            {
                Console.WriteLine("Sajnálom,hogy nincs jó napod!");
            }
            else
            {
                Console.WriteLine("Nem értem a válaszod!");
            }
            Console.ReadKey();
        }
    }
}