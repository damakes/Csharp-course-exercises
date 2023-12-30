using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, jossa kysytään KysyJaTestaaLuku() nimisessä funktiossa käyttäjältä kokonaisluku. 
Funktio palauttaa kokonaislukuarvon seuraavasti:

1, jos syötetty luku on positiivinen.
0, jos syötetty luku on nolla.
-1, jos syötetty luku on negatiivinen. 

Tulosta näiden paluuarvojen perusteella Mainissa ilmoitus ruudulle.

”Luku oli positiivinen”, jos paluuarvo oli 1.
”Luku oli nolla”, jos paluuarvo oli 0
”Luku oli negatiivinen”, jos paluuarvo oli -1.

Käyttäkää Mainissa switch-case-rakennetta

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/
namespace Projekti
{
    class MyProgram
    {
        /*Main
         * Ohjelma tarkistaa luvun ja tulostaa sen mukaisen tekstin käyttäjälle.
         * ”Luku oli positiivinen”, jos paluuarvo oli 1.
         * ”Luku oli nolla”, jos paluuarvo oli 0
         * ”Luku oli negatiivinen”, jos paluuarvo oli -1.
         */
        public static void MyMain()
        {
            //Your code
            int iResult = KysyJaTestaaLuku();

            //Mainissa switch-case
            switch (iResult)
            {
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;
                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;
                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;
                default:
                    Console.WriteLine("Virheellinen syöte");
                    break;
            }
        }
        /*KysyJaTestaaLuku
         * Pyydetään käyttäjää syöttämään kokonaisluku, joka testataan  ja palautetaan.
         */
        public static int KysyJaTestaaLuku()
        {
            Console.Write("Syötä kokonaisluku: ");
            int iNumber;
            if (int.TryParse(Console.ReadLine(), out iNumber))
            {
                if (iNumber > 0)
                    return 1;
                else if (iNumber == 0)
                    return 0;
                else
                    return -1;
            }
            else
            {
                return int.MinValue; //palautetaan arvo
            }
        }
    }
}
