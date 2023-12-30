using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja. Kun käyttäjä syöttää arvoa 
taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan. 
Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot yhden desimaalin
tarkkuudella seuraavasti:

MIN : 12.3
MAX : 34.9


Käytä funktioita:

LuoTaulukko         : funktio palauttaa luodun taulukon
KysyArvotTaulukkoon : funktio saa parametrina taulukon
LajitteleTaulukko   : funktio saa parametrina taulukon
TulostaTiedot       : funktio saa parametrina taulukon

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void MyMain()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/

namespace Projekti
{
    class MyProgram
    {
        public static void MyMain()
        {
            //Your code here
            float[] taulukko = LuoTaulukko();
            KysyArvotTaulukkoon(taulukko);
            LajitteleTaulukko(taulukko);
            TulostaTiedot(taulukko);
        }
        /*LuoTaulukko 
         * funktio palauttaa luodun taulukon
         */
        public static float[] LuoTaulukko()
        {
            return new float[7];
        }
        /*KysyArvotTaulukkoon
         * funktio saa parametrina tauluko
         */
        public static void KysyArvotTaulukkoon(float[] taulukko)
        {
            for (int i = 0; i < taulukko.Length; i++)
            {
                bool bSyöte = false;
                float fArvo = 0;

                while (!bSyöte)
                {
                    Console.Write("Syötä arvo taulukkoon: ");

                    if (float.TryParse(Console.ReadLine(), out fArvo))
                    {
                        bSyöte = true;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen syöte! Syötä uusi arvo.");
                    }
                }

                taulukko[i] = fArvo;
            }
        }

        /*LajitteleTaulukko 
         * funktio saa parametrina taulukon
         */
        public static void LajitteleTaulukko(float[] taulukko)
        {
            Array.Sort(taulukko); 
        }

        /*TulostaTiedot 
         * funktio saa parametrina taulukon
         */
        public static void TulostaTiedot(float[] taulukko)
        {
            Console.WriteLine("MIN : {0:f1}", taulukko[0]);
            Console.WriteLine("MAX : {0:f1}", taulukko[taulukko.Length - 1]);
        }
    }
}
