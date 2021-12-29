using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Wettrennen
    {
        Fahrzeug fahrrad = new Fahrrad(0);
        Fahrzeug ford = new Auto(0);
        Fahrzeug mustang = new Rennwagen(0);
        Fahrzeug rkw = new Krankenwagen(0, false);

        public List<Fahrzeug> teilnehmer = new List<Fahrzeug>();

        public Wettrennen(int dauer)
        {
            teilnehmer.Add(fahrrad);
            teilnehmer.Add(ford);
            teilnehmer.Add(mustang);
            teilnehmer.Add(rkw);

            fahrrad.SetzeGeschwindigkeit(20);
            fahrrad.Bewege(240);
            foreach (var item in teilnehmer)
            {
                if (item.GetType().Name == "Fahrrad")
                {
                    item.PrintStats(true);
                }
                else
                {
                    item.PrintStats();
                }
                Console.WriteLine("------------------------------------------------------");
            }

            Geschwindigkeit();

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            TypeLine($"        Das Rennen geht über {dauer} Minuten");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            Start(dauer);
        }

        private void Geschwindigkeit()
        {
            Console.ReadKey();
            Console.Clear();
            fahrrad.SetzeGeschwindigkeit(20);
            ford.SetzeGeschwindigkeit(150);
            mustang.SetzeGeschwindigkeit(200);
            rkw.SetzeGeschwindigkeit(80);
            Console.ReadKey();
            Console.Clear();
        }

        private void Start(int minuten)
        {
            Console.ReadKey();
            Console.Clear();
            fahrrad.Bewege(minuten);
            fahrrad.PrintStats();
            TypeLine("______________________________________________________",50);
            ford.Bewege(minuten);
            ford.PrintStats();
            TypeLine("______________________________________________________",50);
            mustang.Bewege(minuten);
            mustang.PrintStats();
            TypeLine("______________________________________________________",50);
            rkw.Bewege(minuten);
            rkw.PrintStats();
        }

        static void TypeLine(string line, int duration =100)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(duration); // Sleep for 150 milliseconds
            }
            Console.WriteLine();
        }

    }
}
