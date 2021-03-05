using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];

            Console.WriteLine("Introduzca 10 numeros");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduzca un numero");

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int arreglaso = numeros.Max();

            Console.WriteLine("El numero mayor es: " + arreglaso);

            Console.Read();

        }
    }
}
