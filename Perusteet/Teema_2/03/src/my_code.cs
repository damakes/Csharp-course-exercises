using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Tee ohjelma, joka pyytää käyttäjää syöttämään lampotila -nimiseen muuttujaan
jonkin mielivaltainen lämpötilan arvon (mieti tyyppi tarkasti kun ensin katsot alla olevaa...).

Ohjelma tulostaa sitten seuraavasti, kun lämpötila on:

> 39 tulostuu : "liian kuuma"
11..39 tulostuu : "lämmintä"
0..10 tulostuu : "haaleaa"
-30..-1 tulostuu : "pakkasta"
< -30 tulostuu : "liian kylmä"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            // Your code here
            float fLampotila;

            Console.WriteLine("syötä lämpötila : ");
            fLampotila = float.Parse(Console.ReadLine());

            //liian kuuma
            if (fLampotila > 39)
                Console.WriteLine("liian kuuma");

            //lämmintä
            //suurepi tai yhtäsuuri ja pienempi tai yhtäsuuri
            else if (fLampotila >= 11 && fLampotila <= 39)
                Console.WriteLine("lämmintä");

            //haaleaa
            else if (fLampotila >= 0 && fLampotila <= 10)
                Console.WriteLine("haaleaa");

            //pakkasta
            else if (fLampotila >= -30 && fLampotila <= -1)
                Console.WriteLine("pakkasta");

            //liian kylmä
            else if (fLampotila < -30)
                Console.WriteLine("liian kylmä");
  
        }
    }
}
