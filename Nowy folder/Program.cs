using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Danie> dania = new List<Danie>();
            dania.Add(new Zupa("ogórkowa", 9));
            dania.Add(new Zupa("pomidorowa", 5));
            dania.Add(new Zupa("rosół", 12));
            dania.Add(new DanieGlowne("schabowy", 19));
            dania.Add(new DanieGlowne("bigos", 15));

            dania.ForEach(d => d.Info()); // wyrazenie lambda
            /* petla foreach
            foreach(Danie d in dania)
            {
                d.Info();
            }
            */

            Console.WriteLine();
            Console.WriteLine("Posortowane:");

            dania.Sort();
            dania.ForEach(d => d.Info());

            // ================================================================
            Console.WriteLine();

            Queue<Zamowienie> zamowienia = new Queue<Zamowienie>(new Zamowienie[] { new Zamowienie(10, 201),
                                                                                    new Zamowienie(15, 45),
                                                                                    new Zamowienie(4, 20),
                                                                                    new Zamowienie(8, 56),
                                                                                    new Zamowienie(16, 356),
                                                                                    new Zamowienie(3, 14),
                                                                                    new Zamowienie(20, 156)});

            /* mozna tez tak, ale z tresci zadanie wnioskuję ze chodzi o ten sposob co jest wyzej
            zamowienia.Enqueue(new Zamowienie(10, 201));
            zamowienia.Enqueue(new Zamowienie(15, 45));
            zamowienia.Enqueue(new Zamowienie(4, 20));
            zamowienia.Enqueue(new Zamowienie(8, 56));
            zamowienia.Enqueue(new Zamowienie(16, 356));
            zamowienia.Enqueue(new Zamowienie(3, 14));
            zamowienia.Enqueue(new Zamowienie(20, 156));
            */

            foreach(Zamowienie zam in zamowienia)
            {
                zam.Rabat();
            }

            while (zamowienia.Count > 0)
            {
                Zamowienie zam = zamowienia.Dequeue();
                Console.WriteLine(zam);
            }

            Console.ReadKey();
        }
    }
}
