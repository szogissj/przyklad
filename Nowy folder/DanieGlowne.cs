using System;

namespace ConsoleApplication1
{
    public class DanieGlowne : Danie
    {

        public DanieGlowne(string nazwa, double cena) : base(nazwa, cena)
        {

        }

        public override void Info()
        {
            Console.WriteLine("Danie główne:");
            base.Info();
        }

    }
}
