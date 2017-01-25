using System;

namespace ConsoleApplication1
{
    public class Zupa : Danie
    {

        public Zupa(string nazwa, double cena) : base(nazwa, cena)
        {

        }

        public override void Info()
        {
            Console.WriteLine("Zupa:");
            base.Info();
        }

    }
}
