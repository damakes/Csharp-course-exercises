using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä kokonaislukuja while-silmukassa, kunnes käyttäjä syöttää arvon -1. 
Sen jälkeen tulosta syötettyjen lukujen keskiarvo yhden desimaalin tarkkuudella
alla olevalla tavalla:

"Keskiarvo : 12.1"

Lukua -1 ei oteta keskiarvon laskentaan mukaan.

Jos käyttäjä ei syöttänyt yhtään lukua, niin keskiarvoa ei saa tulostaa
vaan silloin tulostetaan

"Et antanut yhtään lukua"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //muuttujat
            int i = 0, iSyöte, iLaske = 0;
            double Keskiarvo;


            bool bJatketaan = true; //jatketaan lukujen kysymistä

            do
            {
                Console.Write("käyttäjältä kokonaislukuja, kunnes käyttäjä syöttää arvon -1) : ");
                iSyöte = int.Parse(Console.ReadLine());

                if (iSyöte == -1)//kunnes -1
                {
                    bJatketaan = false; //do while muuttuu epätodeksi
                }
                else//käyttäjän syöttämät luvut lasketaan yhteen kierroksilta
                    //joidenka syötew ei ole -1
                {
                    //lasketaan syötettyjen kertojen määrä ja yhteisarvo
                    i += iSyöte;
                    iLaske++;
                }
            } while (bJatketaan); // bJatketaan == true

            if (iLaske==0)//ehto, tulostetaan viesti
            {
                Console.Write("Et antanut yhtään lukua" );
            }
            else //muussa tapauksessa lasketaan keskiarvo ja tulostetaan viesti käyttäjälle
            {
                double iKeskiarvo = (double)i / iLaske;
                Console.WriteLine("Keskiarvo {0:f1}",iKeskiarvo) ;
            }
            
        }
    }
}
