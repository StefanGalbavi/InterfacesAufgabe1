using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAufgabe1
{
    internal class Maus : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Die Maus frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Maus trinkt!");
        }
    }
}
