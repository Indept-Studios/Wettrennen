using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    abstract class Fahrzeug
    {
        public int AktuellePosition { get; private set; }
        public int AnzahlRäder { get; set; }
        public int MaxGeschwindigkeit { get; private set; }
        public int AktuelleGeschwindigkeit { get; private set; }

        protected Fahrzeug(int aktuellePosition, int maxGeschwindigkeit = 0, int anzahlRäder = 0)
        {
            AktuellePosition = aktuellePosition;
            AnzahlRäder = anzahlRäder;
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }

        public void Bewege(double anzahlMinuten)
        {
            AktuellePosition += (AktuelleGeschwindigkeit * (int)anzahlMinuten) / 60;
        }

        public void SetzeGeschwindigkeit(int geschwindigkeit)
        {
            if (geschwindigkeit > MaxGeschwindigkeit)
            {
                Console.WriteLine($"{GetType().Name}: Ich soll {geschwindigkeit} km/h fahren. So schnell kann ich aber nicht fahren, " +
                                    $"maximal sind {MaxGeschwindigkeit} km/h drin");
                geschwindigkeit = MaxGeschwindigkeit;
            }
            AktuelleGeschwindigkeit = geschwindigkeit;
        }

        public int GetMaxGeschwindigkeit()
        {
            return MaxGeschwindigkeit;
        }

        public virtual void PrintStats()
        {
            Console.WriteLine($"Ich bin das {GetType().Name}");
            Console.WriteLine($"Die aktulle Geschwindigkeit beträgt {AktuelleGeschwindigkeit} km/h");
            Console.WriteLine($"Ich bin aktuell {AktuellePosition} km gefahren.");
        }

        public virtual void PrintStats(bool vorsprung)
        {

        }
    }
}
