using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] Estaturas = { 5.7, 6.0, 5.5, 5.9, 5.8 };

            double Promedio = Estaturas.Average();

            Console.WriteLine("El promedio es: " + Promedio);
            Console.WriteLine("Los que estan por encima del promedio son: {0}, {1}, {2} ", Estaturas[1], Estaturas[3], Estaturas[4]);
            Console.WriteLine("Los que estan por debajo del promedio son: {0}, {1} ", Estaturas[0], Estaturas[2]);
            Console.Read();

        }
    }
}
