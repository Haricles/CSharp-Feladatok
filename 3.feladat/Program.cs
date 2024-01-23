/* 
Írj egy programot, ami a felhasználótól bekéri először a keresztnevét, majd a vezetéknevét. A program ezután összefűzi ezeket egy teljes_nev nevű változóba. Végül a program a teljes nevén üdvözli a felhasználót!
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
            Console.WriteLine("Adja meg keresztnevét: ");
            string keresztnev = Console.ReadLine();
            Console.WriteLine("Adja meg vezetéknevét: ");
            string vezeteknev = Console.ReadLine();
            string teljes_nev = keresztnev + " " + vezeteknev;
            Console.WriteLine("Üdv! "+teljes_nev);
            Console.ReadKey();

        }
    }
}