using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele muuttuja pii, jolle annat alkuarvoksi piin likiarvon 6 desimaalin tarkkuudella.
Lue käyttäjältä ympyrän halkaisija ja tulosta ympyrän piiri ja pinta-ala kolmen desimaalin
tarkkuudella seuraavasti (halkaisijaksi annettu 2,5) :

PIIRI     : 7,854
PINTA-ALA : 4,909 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            double dPii = 3.14159;
            double dHalkaisija;


            // Ympyrän piiri = PI*d
            //Ympyrän Pinta-ala = (PI/4)*d^2
            Console.WriteLine("Syötä ympyrän halkaisija: ");
            dHalkaisija = double.Parse(Console.ReadLine());
            Console.WriteLine("PIIRI     : {0:f3}" +"\nPINTA-ALA : {1:f3} ",dPii*dHalkaisija,((dPii/4)*(dHalkaisija*dHalkaisija))); 
        }
    }
}

