using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
Esittele ja anna alkuarvot muuttujille, joihin pitäisi tallentaa seuraavat tiedot:

piin likiarvo
lähiosoite
henkilötunnus
nimesi ensimmäinen kirjain
lämpötila yhden desimaalin tarkkuudella

Tulosta arvot muuttujista allekkain käyttäen sekä Console.WriteLine(), että Console.Write()-komentoja.
Ohjelman pitää tulostaa seuraavat tiedot:

3.14159
Munkkikuja 3
121299A1234
S
-12.4
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //piin likiarvo
            double dPiinLikiarvo = 3.14159;
            Console.WriteLine(dPiinLikiarvo);

            //lähiosoite
            string sLähiosoite = "Munkkikuja 3";
            Console.WriteLine(sLähiosoite);
            
            //Henkilötunnus
            string sHenkilötunnus = "121299A1234";
            Console.WriteLine(sHenkilötunnus);

            //nimesi ensinmäinen kirjain
            char cNimesiEnsinmäinenKirjain = 'S';
            Console.WriteLine(cNimesiEnsinmäinenKirjain);

            //lämpötila yhden desimaalin tarkkuudella
            double dLämpötilaYhdenDesimaalinTarkkuudella = -12.4;
            Console.Write(dLämpötilaYhdenDesimaalinTarkkuudella);



        }
    }
}
