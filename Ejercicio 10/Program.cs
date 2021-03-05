using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Personas persona = new Personas();

            persona.Cargador();

            Console.Read();
        }
    }

    class Personas
    {
        public void Cargador()
        {
            Console.WriteLine("Escriba un nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Escriba una edad: ");
            int Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Usted introdujo lo siguiente: ");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);

            if (Edad >= 18 )
            {
                Console.WriteLine("Usted es mayor de edad, tiene " + Edad);
            }
        }
    }
}
