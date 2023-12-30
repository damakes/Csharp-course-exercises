using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
tee ohjelma, joka tulostaa ensin tiedon siitä, kuinka monta parametria Main-funktioon tuli seuraavalla tavalla.

parametreja tuli 2 kpl

Lisäksi jos ensimmäisen parametri oli "opettaja" niin tulosta "koita saada opiskelijat oppimaan", 
jos se taas oli "opiskelija", niin tulosta "koita opiskella ahkerasti". Jos se oli jotain muuta, 
niin tulosta "nyt en hiffannut"
*/

namespace Projekti
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            //Your code here
            int iParametrienMäärä = args.Length; //Parametrien määrä Main funktiolta
            Console.WriteLine("parametreja tuli {0} kpl", iParametrienMäärä); // tulostetaan määrä

            //toistorakenne for silmukka, tarkistetaan onko parametreja syötetty
            if (iParametrienMäärä > 0)
            {
                string sEnsinmäinenParametri = args[0];//haetaan ensinmäinen 
                if (sEnsinmäinenParametri == "opettaja")
                {
                    Console.WriteLine("koita saada opiskelijat oppimaan");
                }
                else if (sEnsinmäinenParametri == "opiskelija")
                {
                    Console.WriteLine("koita opiskella ahkerasti");
                }
                else
                {
                    Console.WriteLine("nyt en hiffannut");
                }
            }
        }
    }
}