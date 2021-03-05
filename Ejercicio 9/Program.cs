using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {

            klk tabla = new klk();

            tabla.multiplicador();

            Console.Read();
        }
    }

    class klk
    {

        public void multiplicador()
        {
            int valor = 0;

            while(true){

                Console.WriteLine("Introduzca un valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor == -1) { Environment.Exit(0); }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("La multiplcacion entre {1} por {0} es: {2} ", i, valor, (i * valor));
                }
            }
                                                                     
        }
        
        
    }
}
