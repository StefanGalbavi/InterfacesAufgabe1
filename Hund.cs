using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAufgabe1
{
    internal class Hund : ITier
    {
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt!");
        }
    }
}
