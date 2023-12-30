using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä ympyrän säde liukulukuna.

Kysy käyttäjältä myös, haluaako hän tehdä kumpaa seuraavista
(eli käyttäjä syöttää joko numeron 1 tai 2) :

    1 = laske ympyrän piiri
    2 = laske ympyrän pinta-ala

Tämän vastauksen perusteella laske dTulos-muuttujaan joko piiri
tai pinta-ala ja tulosta se. 

Toteuta tämä sekä if-rakenteella että ehdollisella operaattorilla.
Tulostus pitää siis tehdä kaksi kertaa alla olevalla tavalla:

Tulos : 12.22
Tulos : 12.22
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            // Muuttujat
            int iValinta;
            float fSäde;
            double dTulos;
            double dTulos2;


            // Kysytään säde
            Console.WriteLine("Syötä ympyrän säde liukulukuna: ");
            fSäde = float.Parse(Console.ReadLine());

            // Esitellään toiminnot
            Console.Write("    1 = laske ympyrän piiri\n    2 = laske ympyrän pinta-ala");
            iValinta = int.Parse(Console.ReadLine());

            // 1 = Laske ympyrän piiri
            if (iValinta == 1)
                dTulos = 2 * Math.PI * fSäde; // Kaava C = 2pi*r
            else
                dTulos = Math.PI * fSäde * fSäde; // Kaava A = pi*r^2

            // Ehdollinen operaattori
            dTulos2 = (iValinta == 1) ? 2 * Math.PI * fSäde : Math.PI * fSäde * fSäde;

            Console.WriteLine("\n    Tulos : {0:f2}\n    Tulos : {1:f2}", dTulos,dTulos2);
            
        }
    }
}


