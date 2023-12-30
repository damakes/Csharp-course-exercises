using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi kokonaislukumuuttujaa ja lue niihin käyttäjältä arvot.
Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla
(HUOM! Laskutoimituksen tulostus alkaa kaikissa samasta kohdasta!)

Summa :  10 + 5 = 15
Erotus : 10 - 5 = 5
Tulo :   10 * 5 = 50
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            // Your code here
            int luku1 = int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summa :  {0} + {1} = {2}\nErotus : {0} - {1} = {3}\nTulo :   {0} * {1} = {4}"
                , luku1,luku2,(luku1 + luku2),(luku1 - luku2),(luku1 * luku2));
            



        }
    }
}
