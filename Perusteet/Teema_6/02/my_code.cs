using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Jos Main-funktioon ei tullut yhtään parameteriä (0 kpl), niin silloin 
"parametrit.txt tiedostoon kirjoitetaan teksti "Ohjelma ei saanut parametreja".

Jos Main-funktioon tuli parametreja niin kirjoita pelkästään
tulleet parametrit ”parametrit.txt” tiedostoon allekkain.

Lopuksi lue tiedostosta sinne kirjoitetut tiedot rivi kerrallaan ja tulosta näytölle.

Käytä funktioita:

Tallenna
LueJaTulosta


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("parametrit.txt"));
StreamReader sr = new StreamReader(Path("parametrit.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        /*LueJaTulosta
         * Lue ja tulosta tiedot "parametrit.txt" tiedostosta rivi kerrallaan.*/
        public static void LueJaTulosta()
        {
            StreamReader sr = new StreamReader(Path("parametrit.txt"));
            string rivi;
            while ((rivi = sr.ReadLine()) != null)
            {
                Console.WriteLine(rivi);
            }
            sr.Close();
        }

        /*Tallenna
         * Path funktio avataan kirjoittamista varten tiedostoon "parametrit.txt"
         * Silmukka, kahdella eri vaihtoehdolla. Parametrejä saatu enemmän kuin 0, 
         * kirjoitetaan ne tiedostoon allekkain. 
         * Muussa tapauksessa kirjoitetaan "Ohjelma ei saanut parametreja" ja suljetaan tiedosto.*/
        public static void Tallenna(string[] args)
        {
            StreamWriter sw = new StreamWriter(Path("parametrit.txt"));
            if (args.Length > 0)
            {
                sw.WriteLine(string.Join(Environment.NewLine, args));
            }
            else
            {
                sw.WriteLine("Ohjelma ei saanut parametreja");
            }
            sw.Close();
        }

        /*Main
         * Kutsutaan funktioita Tallenna ja LueJaTulosta*/
        public static void Main(string[] args)
        {
            //Your code here
            Tallenna(args);
            LueJaTulosta();
        }
    }
}
