using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;


/*
Esittele nimi, pituus ja paino muuttujat. Esittele lisäksi bmi muuttuja.
Kysy käyttäjältä nimi, pituus metreinä ja paino kilon tarkkuudella.
Laske painoindeksi bmi muuttujaan seuraavasti:

bmi = paino / pituus ^ 2

Tulosta lopuksi:

Olli Opiskelija, pituutesi on 1,81 m ja painosi 104 kg
Painoindeksisi on siten 31,75
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            string sNimi;
            double dPituus;
            double dPaino;

            Console.WriteLine("Syötä Nimesi[Enter], Pituutesi[Enter], Painosi[Enter]");
            sNimi = Console.ReadLine();
            dPituus = double.Parse(Console.ReadLine());
            dPaino = double.Parse(Console.ReadLine());
            double dBmi = (dPaino/((double)dPituus * (double)dPituus));

            Console.WriteLine("{0}, pituutesi on {1} m ja painosi {2} kg\nPainoindeksisi on siten {3:f2}",sNimi,dPituus,dPaino,dBmi);

        }
    }
}

