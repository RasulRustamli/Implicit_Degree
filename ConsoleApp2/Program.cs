namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(290);
            Celcius celcius = kelvin;
            Console.WriteLine(celcius.Degree);
        }
    }
}