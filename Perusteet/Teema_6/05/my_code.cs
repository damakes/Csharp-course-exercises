using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, jolla voit laskea kuinka paljon saat työmarkkinatukea kuukaudessa 
jäädessäsi työttömäksi, kun et ole ollut niin pitkään töissä että saisit 
ansiosidonnaista työttömyyspäivärahaa. Työmarkkinatuen ehdot ja määrät ovat 
yksinkertaistettu malli oikeista työmarkkinatuen ehdoista ja ovat seuraavat: 
 
· Työmarkkinatuen määrä on 32,68 euroa/päivä ja sitä maksetaan viideltä päivältä viikossa.
· Lapset korottavat työmarkkinatukea seuraavasti: yksi lapsi 5,27 euroa/pv, kaksi lasta 7,74 euroa/ pv ja kolmesta tai useammasta yhteensä 9,98 e/pv
· Työllistymistä edistävä palvelu korottaa tukea 4,78 e/pv
· Jos tulot ylittävät 300 euroa, niin jokainen sen määrän ylittävä palkkana maksettu euro vähentää tukea 50 senttiä
· Jos asut vanhempiesi taloudessa tukea vähennetään 50% 

Ohjelmalla voi toistaa työmarkkinatuen laskemista niin monta kertaa kuin haluaa. 
Tuki lasketaan kuukaudelle, jossa on 4 viikkoa.

Alla on esimerkki ohjelman toiminnasta:  

Kuinka monta lasta sinulla on: 5
Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: 2
Kuinka paljon olet saanut palkkaa: 320
Asutko vanhempiesi luona (k/e): k
Saat työmarkkinatukea 426.38 euroa kuukaudessa
 
Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): e

HUOM! Kun käyttäjältä kysytään k/e, niin toteuta sen kysyminen siten, että käyttäjän
pitää painaa enteriä vastauksen jälkeen.
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            //Your code here 
            // Muuttujat
            int iLapsia, iPäivät;
            double dAnsio, dTuki;
            string sAsumismuoto;

            do//Ohjelmalla toistaa työmarkkinatuen laskemista, kunnes käyttäjä vastaa "e".
            {
                Console.WriteLine("Kuinka monta lasta sinulla on: ");
                iLapsia = int.Parse(Console.ReadLine());

                Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: ");
                iPäivät = int.Parse(Console.ReadLine());

                Console.WriteLine("Kuinka paljon olet saanut palkkaa: ");
                dAnsio = double.Parse(Console.ReadLine());

                Console.WriteLine("Asutko vanhempiesi luona (k/e): ");
                sAsumismuoto = Console.ReadLine();

                dTuki = Työ_Markkina_Tuki(iLapsia, iPäivät, dAnsio, sAsumismuoto);

                Console.WriteLine("Saat työmarkkinatukea {0:F2} euroa kuukaudessa",dTuki);

                Console.WriteLine("Haluatko laskea työmarkkinatuen uusilla tiedoilla (k/e): ");
            } while (Console.ReadLine() != "e");
        }

        /*Työ_Markkina_Tuki
         * Työmarkkinatuen määrä on 32,68 euroa/päivä ja sitä maksetaan viideltä päivältä viikossa.
         * Lapset korottavat työmarkkinatukea seuraavasti: yksi lapsi 5,27 euroa/pv, kaksi lasta 7,74 euroa/ pv ja kolmesta tai useammasta yhteensä 9,98 e/pv
         * Työllistymistä edistävä palvelu korottaa tukea 4,78 e/pv
         * Jos tulot ylittävät 300 euroa, niin jokainen sen määrän ylittävä palkkana maksettu euro vähentää tukea 50 senttiä
         * Jos asut vanhempiesi taloudessa tukea vähennetään 50%
         * Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): e
         * HUOM! Kun käyttäjältä kysytään k/e, niin toteuta sen kysyminen siten, että käyttäjän
         * pitää painaa enteriä vastauksen jälkeen.
         */

        public static double Työ_Markkina_Tuki(int iLapsia, int iPäiviä, double dAnsio, string sAsumismuoto)
        {
            double dTuenmääräPäivässä = 32.68;
            double dLapsiTuki = 0;

            if (iLapsia == 1)
                dLapsiTuki = 5.27;
            else if (iLapsia == 2)
                dLapsiTuki = 7.74;
            else if (iLapsia >= 3)
                dLapsiTuki = 9.98;

            double dPalvelutuki = 4.78 * iPäiviä;
            double dTuki = dTuenmääräPäivässä * 5 * 4 + dLapsiTuki * 5 * 4 + dPalvelutuki;

            if (dAnsio > 300)
            {
                double dVähennys = (dAnsio - 300) * 0.5;
                dTuki -= dVähennys;
            }

            if (sAsumismuoto == "k")
                dTuki *= 0.5;

            return dTuki;
        }
    }
}











