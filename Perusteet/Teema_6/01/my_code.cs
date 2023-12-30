using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne "datat.txt" tiedostoon allekkain. 
Älä käytä taulukkoa tässä vaiheessa.

Sen jälkeen luo 40 alkioinen double-taulukko ja lue 
arvot tiedostosta taulukkoon. Tämän jälkeen tulosta taulukon lukujen 
summa, keskiarvo, minimiarvo ja maksimiarvo seuraavalla tavalla

SUMMA : 143.2
KA    : 3.6
MIN   : 1.4
MAX   : 5.7

Käytä funktioita:

ArvoJaTallennaTiedostoon
LueTiedostosta
TulostaTiedot


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta

HUOM 3!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("datat.txt"));
StreamReader sr = new StreamReader(Path("datat.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        /*ArvoJaTallennaTiedostoon
         * for silmukka, random arpoo 40 liukulukua väliltä 1.4-5.8 ja tallennetaan tiedostoon.
         * Erotus 5.8-1.4 = 4.4 on viivottimen leveys kohdasta 1.4 kohtaan 5.8
         * ilmoitetaan väli muodossa (4.4aloituskohtaan lisättävä josta päästään lopetuskohtaan 5.8) + (1.4 aloituskohta) 
         * mikä on = 5.8 - 1.4, jolta väliltä arvotaan.
         */
        public static void ArvoJaTallennaTiedostoon()
        {
            Random random = new Random();
            StreamWriter sw = new StreamWriter(Path("datat.txt"));

            for (int i = 0; i < 40; i++)
            { 
                double liukuluku = random.NextDouble() * 4.4 + 1.4;
                sw.WriteLine(liukuluku.ToString());
            }

            sw.Close();
        }

        /*LueTiedostosta
         * luodaan 40 alkioinen double-taulukko, johon arvotut numerot luetaan. 
         */
        public static double[] LueTiedostosta()
        {
            StreamReader sr = new StreamReader(Path("datat.txt"));
            double[] taulukko = new double[40];

            for (int i = 0; i < 40; i++)
            {
                string rivi = sr.ReadLine();
                taulukko[i] = double.Parse(rivi);
            }

            sr.Close();
            return taulukko;
        }

        /*TulostaTiedot
         * luetaan arvot tiedostosta taulukkoon,jonka jälkeen tulostetaan:
         * summa, keskiarvo, minimiarvo ja maksimiarvo.
         */
        public static void TulostaTiedot(double[] taulukko)
        {
            double summa = 0;
            double minimi = double.MaxValue;
            double maksimi = double.MinValue;

            for (int i = 0; i < taulukko.Length; i++)
            {
                summa += taulukko[i];
                if (taulukko[i] < minimi)
                    minimi = taulukko[i];
                if (taulukko[i] > maksimi)
                    maksimi = taulukko[i];
            }

            double keskiarvo = summa / taulukko.Length;
            Console.WriteLine("SUMMA : {0:f1}\nKA    : {1:f1}\nMIN   : {2:f1}\nMAX   : {3:f1}", summa,keskiarvo,minimi,maksimi);
     
        }
        /*Main
         * kutsutaan funktioita, arpomaan, lukemaan ja tulostamaan.
         */
        public static void MyMain()
        {
            //Your code here
            ArvoJaTallennaTiedostoon();
            double[] taulukko = LueTiedostosta();
            TulostaTiedot(taulukko);
        }
    }
}
