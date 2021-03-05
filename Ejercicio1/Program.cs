using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {

        //Un programa que pida al usuario 4 números, 
        //los memorice (utilizando un array),
        //calcule su media aritmética y después
        //muestre en pantalla la media y los datos tecleados.

        static void Main(string[] args)
        {

            int[] numeros = new int[4];

            Console.WriteLine("Introduzca 4 numeros");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduzca un numero");

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            int operacion = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;

            Console.WriteLine("Resultado de la media aritmetica es: {0} ", operacion);

            foreach (int valor in numeros)
            {
                Console.WriteLine(valor);
            }

            Console.Read();


        }
    }
}
