using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele muuttujat sEtunimi, sSukunimi ja sKokonimi.
Lue käyttäjältä etunimi ja sukunimi ja yhdistä nämä sKokonimi-muuttujaan.
Tulosta nimi näytölle sKokonimi-muuttujasta. Alla esimerkki ohjelmasta:

Anna etunimi : Sami
Anna sukunimi : Lahti

Nimesi on Sami Lahti
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            //Esitellään muuttujat
            string sEtunimi, sSukunimi, sKokonimi;
            
            //anna etunimi 
            Console.WriteLine("Anna etunimi: ");
            sEtunimi = Console.ReadLine();

            Console.WriteLine("Anna sukunimi: ");
            sSukunimi = Console.ReadLine();

            sKokonimi = ("Nimesi on " + sEtunimi + " " + sSukunimi);
            Console.Write(sKokonimi);
        }
    }
}

