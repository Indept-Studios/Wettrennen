using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Fahrrad : Fahrzeug
    {
        public Fahrrad(int aktuellePosition, int maxGeschwindigkeit = 30, int anzahlRäder = 2) 
            : base(aktuellePosition, maxGeschwindigkeit, anzahlRäder)
        {
            
        }

        public override void PrintStats(bool vorsprung)
        {
            if (vorsprung)
            {
                Console.WriteLine($"Ich bin das {GetType().Name}");
                Console.WriteLine($"Ich bekomme einen Vorsprung von 240 Minuten");
                Console.WriteLine($"Die aktulle Geschwindigkeit beträgt {AktuelleGeschwindigkeit} km/h");
                Console.WriteLine($"Ich bin aktuell {AktuellePosition} km gefahren.");
            }
            
        }
    }
}
