/* 
Készíts egy programot, amely a felhasználótól két külön kérdésben megkérdezi, hogy az ikrek (Henrik és Hanna) jönnek-e ma kosrazni! Például így: Jön Henrik ma kosarazni? (igen/nem). A program írja ki, hogy melyik állítás igaz az alábbiak közül:
- egyikük sem jön kosarazni,
- mind a ketten jönnek kosarazni,
- csak az egyikük jön kosarazni.
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
            Console.WriteLine("Jön Henrik ma kosarazni? ");
            string henrik_valasz = Console.ReadLine();
            Console.WriteLine("Jön Hanna ma kosarazni? ");
            string hanna_valasz = Console.ReadLine();
            if ( henrik_valasz == "igen" && hanna_valasz == "igen")
            {
                Console.WriteLine("Mindketten mennek kosarazni");
            }
            else if ( (henrik_valasz == "igen" && hanna_valasz == "nem") || (hanna_valasz == "igen" && henrik_valasz == "nem"))
            {
                Console.WriteLine("Csak az egyikőjük megy kosarazni");
            }
            else
            {
                Console.WriteLine("Egyikőjük sem megy kosarazni");
            }


            Console.ReadKey();
        }
    }
}