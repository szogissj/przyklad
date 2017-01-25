using System;

namespace ConsoleApplication1
{
    public abstract class Danie : IComparable
    {

        public string nazwa;
        protected double cena;

        public Danie(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        public virtual void Info()
        {
            Console.WriteLine("Danie, nazwa: {0}, cena: {1}", this.nazwa, this.cena);
        }

        public int CompareTo(object obj)
        {
            Danie d = (Danie) obj;

            if (this.cena == d.cena)
                return 0;  // sa w tej samej pozycji
            else if (this.cena > d.cena)
                return -1; // this jest przed obj
            else
                return 1;  // this jest po obj
        }

    }
}
