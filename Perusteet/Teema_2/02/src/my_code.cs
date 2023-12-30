using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä kuukauden numero.
Tulosta sen jälkeen onko nyt "syksy", "talvi", "kevät" vai "kesä".
Käytä switch-case rakennetta. Jos käyttäjä syötti kuukauden numeron väärin, niin tulosta
"et antanut kuukauden numeroa oikein"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Your code here
            //esitellään muuttuja
            int iKuukausi;
            //Kysy käyttäjältä kuukauden numero.
            Console.WriteLine("syötä kuukauden numero : ");
            iKuukausi = int.Parse(Console.ReadLine());

            //switch-case
            switch(iKuukausi)
            {   //talvi
                case 12: //joulukuu
                case 1: //tammikuu 
                case 2: //helmikuu
                    Console.WriteLine("talvi");
                    break;
                //kevät
                case 3: //maaliskuu
                case 4: //huhtikuu 
                case 5: //toukokuu 
                    Console.WriteLine("kevt");
                    break;
                //kesä
                case 6: //kesäkuu
                case 7: //heinäkuu
                case 8: //elokuu
                    Console.WriteLine("kesä");
                    break;
                //syksy
                case 9: //syyskuu
                case 10: //lokakuu
                case 11: //marraskuu
                    Console.WriteLine("syksy");
                    break;

                //et antanut kuukauden numeroa oikein
                default:
                    Console.WriteLine("et antanut kuukauden numeroa oikein");
                    break;
            }

        }
    }
}

