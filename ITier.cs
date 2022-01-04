using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAufgabe1
{
    internal interface ITier
    {
        string Geschlecht { get; set; }

        int Alter { get; set; }


        void Fressen();

        void Trinken();
    }
}
