using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä pitkähkö teksti string muuttujaan. Muuta kaikki kirjaimet isoiksi kirjaimiksi 
ja tulosta muutettu teksti. Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti. 
Poista kaikki välilyönnit ja tulosta teksti. Tulosta lopuksi kaikki merkit lopusta alkuun 
yhdellä välilyönnillä eroteltuna 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {

            // Your code here
            //muutujat
            string sTeksti, sIso, sKorvattu, sVälilyönti, sKäännetty;

            Console.WriteLine("Syötä pitkähkö teksti : ");
            sTeksti = Console.ReadLine();

            // Kaikki isoiksi kirjaimiki
            sIso = sTeksti.ToUpper();
            

            // Korvaataan A = ! 
            sKorvattu = sIso.Replace('A', '!');
            

            // Poista välilyönnit
            sVälilyönti = sKorvattu.Replace(" ", "");
            

            // Tulosta merkit lopusta alkuun yhdellä välilyönnillä eroteltuna
            sKäännetty = "";
            for (int i = sVälilyönti.Length - 1; i >= 0; i--)
            {
                sKäännetty += sVälilyönti[i] + " ";
            }
            //tulostetaan kaikki kerralla, prossointi nopeammin näin
            Console.WriteLine("Kaikki isoilla kirjaimilla : {0}\n" +
                "Korvattu A = ! : {1}\n" +
                "Välilyönnit poistettu: {2}\n" +
                "Käänteinen teksti : {3}", sIso, sKorvattu,sVälilyönti,sKäännetty);
        }
    }
}