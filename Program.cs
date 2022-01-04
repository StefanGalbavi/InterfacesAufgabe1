using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund();
            hund.Geschlecht = "Männlich";
            hund.Alter = 10;

            Katze katze = new Katze();
            katze.Geschlecht = "Weiblich";
            katze.Alter = 4;

            Maus maus = new Maus();
            maus.Geschlecht = "Männlich";
            maus.Alter = 1;

            ITier[] tiers = new ITier[3];
            tiers[0] = hund;
            tiers[1] = katze;
            tiers[2] = maus;


            foreach (ITier tier in tiers)
            {
                Console.WriteLine("Geschlecht: " + tier.Geschlecht);
                Console.WriteLine("Alter: " + tier.Alter);
                tier.Fressen();
                tier.Trinken();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
