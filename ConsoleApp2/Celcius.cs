using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Degree-273);
        }
    }
}
