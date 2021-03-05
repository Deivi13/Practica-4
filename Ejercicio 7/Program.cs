using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba un nombre para dividirlo");
           
            string name = Console.ReadLine();
            char[] letterOfNames = new char[name.Length];
            int i = 0;
            foreach (char letter in name)
            {
                letterOfNames[i] = letter;
                i++;
            }
            string newName = string.Join(" ", letterOfNames);

            Console.WriteLine(newName);


            //OTRA FORMA PARA HACER LO MISMO



            //Console.WriteLine("Escriba un nombre para dividirlo");

            //string test = Console.ReadLine();
            //for (int i = 0; i < test.Length; ++i)
            //{
            //    Console.WriteLine(test[i]);
            //}

            Console.Read();

        }
    }
}
