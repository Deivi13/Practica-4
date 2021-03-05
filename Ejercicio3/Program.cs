using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Un programa que almacene en un array el número de días que tiene cada mes(supondremos que es un año no bisiesto),
            //pida al usuario que le indique un mes(1 = enero, 12 = diciembre) y muestre en pantalla el número de días que tiene ese mes.

            var klk = new[]
            {
                new{Mes = "mesnullo", Dias = 0},
                new{Mes = "Enero", Dias = 31},
                new{Mes = "Febrero", Dias = 28},
                new{Mes = "Marzo", Dias = 31},
                new{Mes = "Abril", Dias = 30},
                new{Mes = "Mayo", Dias = 31},
                new{Mes = "Junio", Dias = 30},
                new{Mes = "Julio", Dias = 31},
                new{Mes = "Agosto", Dias = 31},
                new{Mes = "Septiembre", Dias = 30},
                new{Mes = "Octubre", Dias = 31},
                new{Mes = "Noviembre", Dias = 30},
                new{Mes = "Diciembre", Dias = 31},
            };

            Console.WriteLine("Elija un mes: \n 1) Enero \n 2) Febrero \n 3) Marzo \n 4) Abril  \n 5) Mayo \n 6) Junio \n 7) Julio \n 8) Agosto \n 9) Septiembre \n 10) Octubre \n 11) Noviembre \n 12) Diciembre ");
            int mes = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("El mes seleccionado con su dias: " + klk[mes]);

            Console.Read();
        }

    }


}
