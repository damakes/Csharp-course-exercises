using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Laita vakioon ARVATTAVA_LUKU joku arvo väliltä 1-500. Tee ohjelma, joka pyytää arvaamaan lukua
do-while-silmukassa, kunnes käyttäjä arvaa luvun oikein.

Jos käyttäjä syötti isomman luvun kuin vakiossa, niin tulosta :

"Annoit liian ison luvun" 

Jos taas käyttäjän syöttämä luku oli pienempi kuin vakion luku niin tulosta :

"Annoit liian pienen luvun"

Kun käyttäjä arvaa luvun oikein niin tulosta :

"Oikein, arvasit luvun 27 kerralla!" 

Missä siis arvo 27 kertoo montako kierrosta meni ennen kuin käyttäjä arvasi oikein

Kun testaat/palautat koodin, niin laita vakioon arvoksi 308.
*/

    namespace Projekti
    {
        class Program
        {
            //Vakio, esitellään se funktion ulkopuolella jolloin kaikki funktiot voivat sitä käyttää
            const int ARVATTAVA_LUKU = 308;

            static void Main()
            {
                // Your code here//

                //Muuttujat
                int arvaus;
                int arvauskerrat = 0;

                do
                {
                    Console.Write("Arvaa luku: ");
                    arvaus = int.Parse(Console.ReadLine());

                    arvauskerrat++; //lisätään muuttujaan ++ operaattorilla yksi toteutunut silmukka kierros

                    if (arvaus > ARVATTAVA_LUKU)
                    {
                        Console.WriteLine("Annoit liian ison luvun");
                    }
                    else if (arvaus < ARVATTAVA_LUKU)
                    {
                        Console.WriteLine("Annoit liian pienen luvun");
                    }
                } while (arvaus != ARVATTAVA_LUKU); //niin kauan kuin arvaus ei ole 308 while silmukka pyörii

                Console.WriteLine("Oikein, arvasit luvun {0} kerralla!", arvauskerrat);
            }
        }
    }
