using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele 10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10. 
Vain parilliset luvut sallitaan.Jos arvottiin pariton luku niin sen 
tilalle on arvottava uusi luku.

Tulosta luvut ensin taulukon alusta loppuun tabulaattorilla eroteltuna
ja seuraavalla rivillä lopusta alkuun tabulaattorilla eroteltuna
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10
            int[] taulukko = new int[10];

            // olio satunnaisluvuille
            Random random = new Random();

            for (int i = 0; i < taulukko.Length; i++)
            {
                int arvottuLuku = random.Next(0, 6) * 2; // Arvotaan parillinen luku väliltä 0-10
                taulukko[i] = arvottuLuku;
            }

            // Tulosta luvut taulukon alusta loppuun tabulaattorilla eroteltuna
            for (int i = 0; i < taulukko.Length; i++)
            {
                Console.Write(taulukko[i] + "\t");
            }

            Console.WriteLine(); // Rivinvaihto

            // Tulosta luvut taulukon lopusta alkuun tabulaattorilla eroteltuna
            for (int i = taulukko.Length - 1; i >= 0; i--)
            {
                Console.Write(taulukko[i] + "\t");
            }

            Console.WriteLine(); // Rivinvaihto
        }
    }
}