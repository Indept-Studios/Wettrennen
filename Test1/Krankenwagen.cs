using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Krankenwagen : Fahrzeug
    {
        public bool Blaulicht { get; set; }
        public Krankenwagen(int aktuellePosition, bool blaulicht, int maxGeschwindigkeit = 140, int anzahlRäder = 4)
            : base(aktuellePosition, maxGeschwindigkeit, anzahlRäder)
        {
        }

        public void Sirene()
        {
            Blaulicht = !Blaulicht;
        }
    }
}
