using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi laskurimuuttujaa ja tulosta niiden avulla for-silmukassa:

11       10
12       9
13       8
...
19       2
20       1

Eli toinen arvo toisesta muuttujasta ja toinen toisesta ja
tabulointimerkki lukujen välissä
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            /* laskurimuuttujat iA ja iB
             * iA : on yhtäkuin = 11 ja on pienempi tai yhtä suuri kuin 20,
             * iA : suurennetaan ++ operaattorilla Ai yhdellä lukuun 20 saakka
             * iB : on yhtäkuin = 10 ja on suurempi tai yhtä suuri kuin 1
             * iB : pienennetään -- operaattorilla iB yhdellä lukuun 1 saakka
             */

            int iA, iB;

            for (iA = 11, iB = 10; iA <= 20 && iB >= 1; iA++, iB--)
                Console.WriteLine("{0}\t{1}", iA, iB);
        }
    }
}

