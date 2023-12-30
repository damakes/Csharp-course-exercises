using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä merkkejä, kunnes käyttäjä painaa enteriä. Isot kirjaimet tulostuvat pienenä 
ja pienet kirjaimet tulostuvat isona. Muut merkit eivät tulostu.

Riittää, että toimii kirjaimilla väliltä a-z ja A-Z.
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {

            //Your code here

            //Muuttujut
            string sSyöte; 

            Console.WriteLine("Lue käyttäjältä merkkejä: ");
            sSyöte = Console.ReadLine(); 

            //käydeen käyttäjän koko syöte läpi foreach silmuikalla 
            foreach (char cMerkki in sSyöte)
            {
                //ehto 
                if (char.IsLower(cMerkki))
                {
                    //pienet kirjaimet muunnetaan isoiksi
                    Console.Write(char.ToUpper(cMerkki));
                }
                else if (char.IsUpper(cMerkki))
                {
                    // Isot kirjaimet muunntetaan pieniksi
                    Console.Write(char.ToLower(cMerkki));
                }
            }
        }
    }
}
