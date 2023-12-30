using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, joka laskee mäkihyppääjän yhden kierroksen suorituspisteet. Ohjelma kysyy hypyn pituuden 
(liukuluku 0.5 metrin välein ja pituuden oltava > 0) sekä viiden arvostelutuomarin 
tyylipisteet (0-20 välillä 0.5 välein eli 
esim. 16.5 tai 17.0 tai 18.5). Vinkki. Jakojäännöksellä saa tutkittua onko puolen pisteen/metrin välein

Hyppääjän pisteet muodostuvat kaavasta.

pisteet = (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. 

Tyylipisteissä siis parhain ja huonoin pistemäärä tipahtaa pois.

Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla. Laita kriittinen piste vakioon KR_PISTE. 
Tulosta lopuksi hypyn pituus ja hypyn pisteet yhden desimaalin tarkkuudella seuraavalla tavalla.

PITUUS  : 115,5 m
PISTEET : 161,4

Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään ja kun käytät viittauksia, niin pitää
käyttää out-viittausta):

KysyHypynPituus
KysyTuomareidenPisteet
LaskeHypynPisteet
Tulosta

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void MyMain()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/


namespace Projekti
{
    class MyProgram
    {
        /* Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla. 
         * kriittinen piste vakioon KR_PISTE. 
         * Tulosta lopuksi hypyn pituus ja hypyn pisteet yhden desimaalin tarkkuudella seuraavalla tavalla.
         */
        const float KR_PISTE = 90;

        /* Main metodi
         * joka suorittaa ohjelman päätoiminnallisuuden.
         * Kysyy käyttäjältä hypyn pituuden ja tuomareiden pisteet, laskee hyppääjän pisteet ja tulostaa ne.
         */
        public static void MyMain()
        {
            //Your code here
            double dHypynPituus, dHypynPisteet;
            KysyHypynPituus(out dHypynPituus);

            double[] tuomareidenPisteet = new double[5];
            KysyTuomareidenPisteet(out tuomareidenPisteet);

            LaskeHypynPisteet(dHypynPituus, tuomareidenPisteet, out dHypynPisteet);

            Tulosta(dHypynPituus, dHypynPisteet);

        }
        /* KysyHypynPituus metodi 
         * kysyy käyttäjältä hypyn pituuden ja tarkistaa syötteen kelvollisuuden.
         * Hyppypituuden tulee olla positiivinen luku ja 0.5 metrin välein.
         */
        public static void KysyHypynPituus(out double dPituus)
        {
            dPituus = 0;
            double dJaannos;

            while (true)
            {
                Console.Write("Syötä hypyn pituus (metreinä): ");
                string sSyöte = Console.ReadLine();

                if (double.TryParse(sSyöte, out dPituus) && dPituus > 0)
                {
                    dJaannos = dPituus % 0.5;

                    if (dJaannos == 0 || Math.Abs(dJaannos - 0.5 * Math.Round(dPituus * 2)) == 0)
                        break;
                    else
                        Console.WriteLine("Virhe: Hypyn pituuden tulee olla 0.5 metrin välein!");
                }
                else
                {
                    Console.WriteLine("Virhe: Syötä kelvollinen luku (suurempi kuin 0)!");
                }
            }
        }

        /* KysyTuomareidenPisteet metodi
         * kysyy käyttäjältä tuomarien antamat pisteet ja tarkistaa nämä 
         * Pisteiden tulee olla välillä 0-20 ja 0.5 pisteen välein.
         */
        public static void KysyTuomareidenPisteet(out double[] pisteet)
        {
            pisteet = new double[5]; //Taulukko, johonka viiden tuomarin pisteet

            double dJaannos; 

            //toistorakenne for silmukka
            for (int i = 0; i < 5; i++) // 5 TUomarin pisteitten keräys 5.
            {
                while (true)
                {
                    Console.Write("Syötä tuomarin {0} pisteet (0-20): ", i + 1); 
                    string syote = Console.ReadLine();


                    //tarkistetaan käyttäjän syöte jotta se on väliltä 0-20, 0.0 ja 0.5 tarkkuudella
                    if (double.TryParse(syote, out pisteet[i]) && pisteet[i] >= 0 && pisteet[i] <= 20) 
                    {
                        dJaannos = pisteet[i] % 0.5;

                        if (dJaannos == 0 || dJaannos == 0.5)
                            break;
                        else
                            Console.WriteLine("Virhe: Pisteiden tulee olla 0.5 pisteen välein!");
                    }
                    else
                    {
                        Console.WriteLine("Virhe: Syötä kelvollinen luku (0-20)!");
                    }
                }
            }

            Array.Sort(pisteet); // Pisteitten järjestys nousevaan
        }

        /* LaskeHypynPisteet metodi 
         * laskee hyppääjän pisteet annetun kaavan mukaisesti.
         * Pisteet lasketaan kaavalla: (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60.
         */
        public static void LaskeHypynPisteet(double dHypynPituus, double[] tuomareidenPisteet, out double dHypynPisteet)
        {
            Array.Sort(tuomareidenPisteet); // Pisteitten järjestys nousevaan
            dHypynPisteet = (dHypynPituus - KR_PISTE) * 1.8 + tuomareidenPisteet[1] + tuomareidenPisteet[2] + tuomareidenPisteet[3] + 60;

        }

        /* Tulosta metodi 
         * tulostaa hypyn pituuden ja hypyn pisteet yhden desimaalin tarkkuudella.
         */
        public static void Tulosta(double dHypynPituus, double dHypynPisteet)
        {
            Console.WriteLine("PITUUS  : {0:f1} m", dHypynPituus);
            Console.WriteLine("PISTEET : {0:f1}", dHypynPisteet);
        }
    }
}

