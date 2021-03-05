using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //arreglo para guardar nombres
            List<string> nombres = new List<string>();
            //nombre de usuarios
            string nombre = "";
            //iterador
            int i = 0;


            do
            {
                Console.WriteLine("Introduce el nombre numero #{0}", i + 1);
                nombre = Console.ReadLine();
                nombres.Add(nombre);
                i++;


            } while (nombre != "" || i != 100);


            foreach (var name in nombres)
            {
                Console.WriteLine(name);
            }

            Console.Read();

        }
    }
}
