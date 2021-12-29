using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Auto : Fahrzeug
    {
        public Auto(int aktuellePosition, int maxGeschwindigkeit = 140, int anzahlRäder = 4) 
            : base(aktuellePosition, maxGeschwindigkeit, anzahlRäder)
        {
        }
    }
}
