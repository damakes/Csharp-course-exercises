using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lotossa arvotaan seitsemän (7) varsinaista numeroa ja yksi (1) lisänumero. Numerot ovat väliltä 1-40. 
Esittele kahdeksan (8) alkioinen lotto-taulukko ja arvo siihen lottonumerot (7 ensimmäistä on siis 
varsinaisia lottonumeroita ja viimeinen on lisänumero). Muista, että samaa numeroa ei saa tulla 
lottoriviin eli mieti miten voisit tarkistaa onko arvottu numero jo lottorivissä entuudestaan ja 
silloin sen tilalle pitää arpoa uusi numero.

Tulosta ensi arvottu rivi ja sitten lajiteltu lottorivi seuraavasti:

ARVOTTU   : 31 4 1 19 25 16 12 13  
LAJITELTU : 1 4 12 16 19 25 31 + 13

HUOM!! seitsemän varsinaista numeroa on lajiteltu suuruusjärjestykseen! 
Mutta lisänumeroa ei tietenkään saa ottaa lajitteluun mukaan! Löytysköhän Array.Sort:sta 
sellainen ominaisuus, jolla tämän saisi ratkaistua?
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //kahdeksan(8) alkioinen lotto-taulukko
            int[] lotto = new int[8];

            //muuttujat
            int iArvottu, iLisa;

            //olio satunnaisluvuille
            Random random = new Random();

            //arvotaan numerot for silmukkaa käyttäen
            for (int i = 0; i < 8; i++)
            {
                iArvottu = random.Next(1, 41);//väliltä 1-41

                while (Array.IndexOf(lotto, iArvottu) != -1)
                {
                    iArvottu = random.Next(1, 41);
                }
                lotto[i] = iArvottu;

            }
            //arvotaan lisä numero
            int lisanumero = random.Next(1, 41);
            lotto[7] = lisanumero;

            // Tulosta arvottu rivi
            Console.Write("ARVOTTU   : ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(lotto[i] + " ");
            }
            Console.WriteLine();

            // Lajitellaan varsinaiset numerot suuruusjärjestykseen
            Array.Sort(lotto, 0, 7);

            // Tulosta lajiteltu lottorivi
            Console.Write("LAJITELTU : ");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(lotto[i] + " ");
            }
            Console.Write("+ " + lotto[7]);

            Console.WriteLine();
        }
    }
}



