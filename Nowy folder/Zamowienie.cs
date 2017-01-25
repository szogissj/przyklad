
namespace ConsoleApplication1
{
    public class Zamowienie : IRabat
    {

        private int ileDan;
        private double suma;

        public Zamowienie(int ileDan, double suma)
        {
            this.ileDan = ileDan;
            this.suma = suma;
        }

        public void Rabat()
        {
            if(this.ileDan > 10)
            {
                this.suma -= this.suma * 0.1;
            }
        }

        public override string ToString()
        {
            return "Zamówienie, liczba dań: " + this.ileDan + ", suma: " + this.suma;
        }
    }
}
