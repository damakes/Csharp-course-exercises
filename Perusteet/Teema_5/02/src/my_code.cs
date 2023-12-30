using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Kysy käyttäjältä kuinka iso taulukko luodaan. Luo taulukko ja arvo siihen arvosanoja 
väliltä 0-5. Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0. 
Tulosta määrä näytölle seuraavalla tavalla:

Hylättyjä arvosanoja oli : 4 kpl

Käytä ohjelmassa seuraavia funktioita :

KysyKoko        (funktio ei palauta mitään, viittaukset out:lla)
LuoTaulukko     (funktio ei palauta mitään, viittaukset out:lla, parametrina ensin iKoko tieto, sitten taulukko)
ArvoArvosanat   (funktio ei palauta mitään)
TutkiHylatyt    (funktio palauttaa hylättyjen määrän)
Tulosta         (funktio ei palauta mitään)


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
        public static void MyMain() 
        {
            //Your code here
            int iKoko;
            KysyKoko(out iKoko);
            int[] taulukko;
            LuoTaulukko(iKoko, out taulukko);
            ArvoArvosanat(taulukko);
            int iHylatyt = TutkiHylatyt(taulukko);
            Tulosta(iHylatyt);
        }
        /*Kysykoko
         * Parametri iKoko, joka viitataan ulos käyttäjän syöttämä arvo sisällä.
         */
        public static void KysyKoko(out int iKoko)
        {
            Console.Write("Kuinka iso taulukko luodaan? ");
            iKoko = int.Parse(Console.ReadLine());
        }

        /*LuoTaulukko
         * Parametri iKoko käyttäjän syötteestä ja taulukko
         * Taulukko luodaan käyttäjän syötteen perusteella
         */
        public static void LuoTaulukko(int iKoko, out int[] taulukko)
        {
            taulukko = new int[iKoko];
        }

        /*ArvoArvosanat
         * Taulokon parametriksi, johonka arvotaan arvosanoja väliltä 0-5
         */
        public static void ArvoArvosanat(int[] taulukko)
        {
            Random random = new Random();
            for (int i =0; i < taulukko.Length; i++)
            {
                taulukko[i] = random.Next(6); 
            }
        }
        /*TutkiHylatyt
         * Taulokon parametriksi,tutkitaan hylätyt 0
         */
        public static int TutkiHylatyt(int[] taulukko)
        {
            int iHylatyt =0;
            foreach (int iArvosana in taulukko)
            {
                if (iArvosana == 0)
                {
                    iHylatyt++;
                }
            }
            return iHylatyt;
        }
        
        /*Tulosta 
         * Parametrin hylätyt, jotka tulostetaan.
         */
        public static void Tulosta(int iHylatyt)
        {
            Console.WriteLine("Hylättyjä arvosanoja oli : {0} kpl", iHylatyt);
        }
    }
}  