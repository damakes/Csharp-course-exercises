using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele 3 alkioinen double taulukko ja lue siihen käyttäjältä arvot. 
Tulosta lopuksi syötettyjen lukujen summa ja keskiarvo seuraavasti:

SUMMA :     12.23
KESKIARVO : 4.07
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here

            //3 alkioinen double taulukko
            double[] taulukko = new double[3];

            Console.Write("Syötä luku 1 : ");
            taulukko[0] = double.Parse(Console.ReadLine());
            Console.Write("Syötä luku 2 : ");
            taulukko[1] = double.Parse(Console.ReadLine());
            Console.Write("Syötä luku 3 : ");
            taulukko[2] = double.Parse(Console.ReadLine());

            // lasketaan keskiarvo ja summa
            //keskiarvo hyödyntäen taulukko.lenght, haetaan elemenntien määrä(taulukoiden)
            Console.WriteLine("SUMMA :     {0:f2}\nKESKIARVO : {1:f2}", taulukko[0] + taulukko[1] + taulukko[2], 
                (taulukko[0] + taulukko[1] + taulukko[2])/taulukko.Length);
        }
    }
}
