using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä koenumero 4-10 väliltä. Jos käyttäjä syötti arvosanan väärin,
niin tulosta "et antanut arvosanaa annetulta väliltä". Muussa tapauksessa tulosta:

"hyvä", jos arvosana oli 9 tai 10
"kelpo", jos 7-8
"tyydyttävä", jos 5-6
"heikko", jos 4

Toteuta ohjelma if-rakenteella
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            int iArvosana;

            Console.WriteLine("Anna arvosana väliltä 4-10 : ");
            iArvosana = int.Parse(Console.ReadLine());

            //arvosana on suurempi tai yhtä suuri ja pienempi tai yhtäsuuri
            if (iArvosana >= 9 && iArvosana <= 10)  //"hyvä", jos arvosana oli 9 tai 10
                Console.WriteLine("hyvä");

            //arvosana on suurempi tai yhtä suuri ja pienempi tai yhtäsuuri
            else if (iArvosana >= 7 && iArvosana <= 8) //"kelpo", jos 7 - 8
                Console.WriteLine("kelpo");
            else if (iArvosana >=5 && iArvosana <=6) //"tyydyttävä", jos 5 - 6
                Console.WriteLine("tyydyttävä");

            //arvosana on yhtäsuuri
            else if (iArvosana == 4) //"heikko", jos 4
            Console.WriteLine("heikko");

            else
                Console.WriteLine("et antanut arvosanaa annetulta väliltä");

        }
    }
}
