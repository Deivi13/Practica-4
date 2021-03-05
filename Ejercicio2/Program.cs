using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Un programa que pida al usuario 5 números reales(pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.

            double[] numeros = new double[5];

            Console.WriteLine("Introduzca 5 numeros");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduzca un numero");

                numeros[i] = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Los numeros son: " + numeros[i]);
            }


            //OTRA FORMA DE REVERTIRLO PROFE!!!!!!!!!


            //var nuevoarreglo = numeros.Reverse();
            //foreach (var item in nuevoarreglo)
            //{
            //    Console.WriteLine("Los numeros son: " + item);
            //}

            Console.Read();




        }
    }
}
