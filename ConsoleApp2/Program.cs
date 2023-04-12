namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(100);
            Euro euro = new Euro(100);
            Manat manat = dollar;
            Manat manat1 = euro;
            Console.WriteLine(manat.Valyuta);
            Console.WriteLine(manat1.Valyuta);
           
        }
    }
    class Dollar
    {
        public double Valyuta { get; set; }
        public Dollar(double valyuta)
        {
                Valyuta = valyuta;
        }
    }
    class Euro
    {
        public double Valyuta { get; set; }

        public Euro(double valyuta)
        {
            Valyuta = valyuta;
        }
    }
    class Manat
    {
        public double Valyuta { get; set; }

        public Manat(double valyuta)
        {
            Valyuta = valyuta;
        }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Valyuta*1.7);
        }
        public static implicit operator Manat(Euro euro)
        {
            return new Manat(euro.Valyuta * 1.86);
        }
    }
}