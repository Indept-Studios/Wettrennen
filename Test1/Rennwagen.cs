using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Rennwagen : Fahrzeug
    {
        public Rennwagen(int aktuellePosition, int maxGeschwindigkeit = 220, int anzahlRäder = 4) 
            : base(aktuellePosition, maxGeschwindigkeit, anzahlRäder)
        {
        }
    }
}
