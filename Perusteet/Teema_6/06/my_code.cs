using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tehtävänä on laskea pankkisiirtojen viitteistä tuttu tarkistenumero ja
tulostaa viitenumero ryhmiteltynä.

Alla on esimerkki laskemisesta. Lasketaan runko-osalle 12345 tarkistenumero:

          runko-osa     1     2     3     4     5
     painokertoimet     3     7     1     3     7
                        -------------------------
              tulot     3    14     3    12    35

näiden tulojen summa on 67

Siis oikealta alkaen kerrotaan numerot vuorollaan painoilla 
7, 3, 1, 7, 3, 1, 7, ... jne

Tarkistenumero on tulojen summa vähennettynä seuraavasta täydestä 
kymmenestä (paitsi jos summa on tasakymmeniä, on tarkiste nolla). 

Esimerkin tapauksessa siis tarkiste on 3. 

Alkuperäinen runko-osa ja tarkiste tulostetaan ruudulle näin: oikeanpuoleisimpaan 
ryhmään neljä + tarkiste, muihin viisi merkkiä ja ekaan niin monta kuin riittää

Ohjelman tulisi toimia seuraavasti:

Anna viitteen runko-osa : 325308000102798049011

Viitenumero : 32 53080 00102 79804 90117
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            //Your code here
            Console.Write("Anna viitteen runko-osa: "); 
            string sRunko_osa = Console.ReadLine();


            string sOsa_tarkistettu = Tarkistus(sRunko_osa); 
            string sViite_numero = Ryhmittely(sOsa_tarkistettu); 
            Console.WriteLine("Viitenumero : {0}" , sViite_numero);
        }

        /*Tarkistus 
         * Funktio laskee viitenumeron tarkistenumeroineen
         */
        static string Tarkistus(string sRunko_osa)
        {
            // Tarkistenumeron laskentaan käytettävät painokertoimet
            int[] iPainokertoimet = { 7, 3, 1, 7, 3, 1, 7, 3, 1 };
            int iSumma = 0;

            // Käydään läpi runko-osan numerot oikealta vasemmalle
            for (int i = sRunko_osa.Length - 1; i >= 0; i--)
            {
                // Muutetaan numeroksi ja kerrotaan painokertoimella
                int iNumero = int.Parse(sRunko_osa[i].ToString());
                iSumma += iNumero * iPainokertoimet[(sRunko_osa.Length - i - 1) % 9];
            }

            // Lasketaan tarkistenumero (10 - summa % 10) % 10
            int iTarkistenumero = (10 - (iSumma % 10)) % 10;

            // Palautetaan runko-osa ja tarkistenumero merkkijonona
            return sRunko_osa + iTarkistenumero.ToString();
        }

        /*Ryhmittely
         * Funktio ryhmittelee viitenumeron 5 numeron ryhmiin
         */
        static string Ryhmittely(string sViite_numero)
        {
            string sJärjestys = "";

            // Käydään läpi viitenumero oikealta vasemmalle
            for (int i = sViite_numero.Length - 1; i >= 0; i--)
            {
                // Lisätään numerot muodostettavaan merkkijonoon oikealta vasemmalle
                sJärjestys = sViite_numero[i] + sJärjestys;

                // Lisätään välilyönti joka viidennen numeron jälkeen, paitsi jos ollaan ensimmäisessä numerossa
                if ((sViite_numero.Length - i) % 5 == 0 && i != 0)
                    sJärjestys = " " + sJärjestys;
            }

            // Palautetaan ryhmitelty viitenumero
            return sJärjestys;
        }
    }
}


