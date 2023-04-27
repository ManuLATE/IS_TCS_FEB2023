using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    internal class ServicioClima : IServicioClima
    {
        public double convertirCentigrados(double centigrados)
        {
            double fahrenheit = (centigrados * 9/5) + 32;
            return fahrenheit;
        }

        public double convertirFahrenheit(double fahrenheit)
        {
            double centigrados = (fahrenheit - 32) * 5/9;
            return centigrados;
        }
    }
}
