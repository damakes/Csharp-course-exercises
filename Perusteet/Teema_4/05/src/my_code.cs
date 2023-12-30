using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele sellainen 2-ulottoinen taulukko, johon voit tallentaa maanantain ja perjantain välisenä aikana 
neljä mittaustulosta jokaiselta päivältä (mittaustulos on sademäärä milleinä). Lue käyttäjältä nämä 
mittaustulokset taulukkoon ja tulosta lopuksi jokaisen päivän mittaustulosten 
keskiarvo seuraavan esimerkin mukaisesti :

Maanantai   : 12.0 mm
Tiistai     : 0.0 mm
Keskiviikko : 1.9 mm
Torstai     : 22.8 mm
Perjantai   : 0.9 mm
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            //muuttujat

            // 2-ulotteinen taulukko
            // 5 päivältä mittaukset, 4 mittausta.
            double[,] Sade = new double[5, 4];

            string[] Paivat = { "Maanantai", "Tiistai", "Keskiviikko", "Torstai", "Perjantai" };

            // Lue mittaustulokset ja tallenna taulukkoon
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}:",Paivat[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Mittaustulos {0}: ",j + 1);
                    Sade[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Tulosta mittaustulosten keskiarvot päivittäin
            for (int i = 0; i < 5; i++)
            {
                double summa = 0;
                for (int j = 0; j < 4; j++)
                {
                    summa += Sade[i, j];
                }
                double keskiarvo = summa / 4;
                //asetetaan välin pituudeksi -12 päivän, sekä tulostetaan yhden desimaalin tarkkuudella
                Console.WriteLine("{0,-12}: {1:f1} mm", Paivat[i], keskiarvo);
            }
        }
    }
}