using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä kaksi kokonaislukua sekä operaatio joka lukujen välillä
suoritetaan (voi olla +, -, * tai / eli kyseessä siis nelilaskin).

Käytä operaation tallentamiseen string-tyyppistä muuttujaa.

Tutki switch-case rakenteessa minkä operaation käyttäjä syötti ja
tulosta sen perusteella lukujen laskutoimitus vastauksineen. Osamäärä
tulostetaan kahden desimaalin tarkkuudella

Esimerkiksi
jos käyttäjä syöttää luvut "12" ja "13" ja operaatioksi "+" niin tulostetaan

12 + 13 = 25

Jos operaatio oli annettu väärin, niin tulosta virheilmoitus
"annoit operaation väärin"

Nollalla jakoa ei saa ohjelmassa tapahtua, vaan silloin tulostetaan
"Nollalla jako, ei voida suorittaa"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            double dLuku1, dLuku2;
            string sOperaatio;
            //luku1
            Console.Write("Anna luku1 : ");
            dLuku1 = double.Parse(Console.ReadLine());

            //luku2
            Console.Write("Anna luku2 : ");
            dLuku2 = double.Parse(Console.ReadLine());

            //operaatio
            Console.Write("Anna suoritettava operaatio ( +, -, * tai / )");
            sOperaatio = Console.ReadLine();

            //if else + switch case

            if (sOperaatio == "/")//ehto, muuttujan arvo yhtä suuri == /
            {
                if (dLuku1 == 0 || dLuku2 == 0)//ehto on tosi, mikäli toinen muuttujista on yhtä suuri tai molemmat
                {
                    Console.WriteLine("Nollalla jako, ei voida suorittaa");
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", dLuku1, dLuku2, (dLuku1 / dLuku2)); //jako
                }
                
            }
            else 
            {
                switch (sOperaatio)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", dLuku1, dLuku2, (dLuku1 + dLuku2)); break;//plus
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", dLuku1, dLuku2, (dLuku1 - dLuku2)); break;//miinus
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", dLuku1, dLuku2, (dLuku1 * dLuku2)); break;//kerto
                    default:
                        Console.WriteLine("annoit operaation väärin"); break;//virheellinen valinta

                }
                
            }
        }
    }
}

