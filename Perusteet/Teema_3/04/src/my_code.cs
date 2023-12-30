using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä mistä luvusta tulostetaan ja mihin asti ja millaisella askelluksella. 

HUOM! Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0.
Muuten kysyttävä tiedot uudestaan.

Tulosta lukusarjat sekä while-, do-while- että for-silmukoilla. 

Esimerkki:
Jos mistä on 5, mihin on 11 ja askellus on 2, niin ohjelma tulostaa kaikilla
kolmella silmukalla saman, alla olevan lukusarjan (lukujen välissä kaksi välilyöntiä).
Tulosta myös millä silmukalla luvut on tulostettu. 

WHILE:
5  7  9  11

DO-WHILE:
5  7  9  11

FOR:
5  7  9  11
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //muuttujat
            int iMista, iMihin, iAskellus, iI;

            do
            {
                Console.Write("Mistä luvusta tulostetaan: ");
                iMista = int.Parse(Console.ReadLine());

                Console.Write("Mihin asti tulostetaan: ");
                iMihin = int.Parse(Console.ReadLine());

                Console.Write("Millaisella askelluksella: ");
                iAskellus = int.Parse(Console.ReadLine());

                if (iMista >= iMihin || iAskellus <= 0)
                {
                    Console.WriteLine("HUOM! Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0");
                }
            } while (iMista >= iMihin || iAskellus <= 0); //ehto on tosi mikäli toinen tai molemmat ovat tosi

                Console.WriteLine("WHILE:");
                iI = iMista;

            while (iI <= iMihin)

            {
                Console.Write(iI + "  ");
                iI += iAskellus;
            }

                Console.WriteLine();
                Console.WriteLine("DO-WHILE:");
                iI = iMista;

            do
            {
                Console.Write(iI + "  ");
                iI += iAskellus;

            } while (iI <= iMihin);

                Console.WriteLine();
                Console.WriteLine("FOR:");

            for (iI = iMista; iI <= iMihin; iI += iAskellus)
            {
                Console.Write(iI + "  ");
            }
        }
    }
}