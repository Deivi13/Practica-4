using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace ejercicio_6_real
{
    class ImagenesData
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public void isFull(int ListCount)
        {
            if (ListCount == 700)
            {
                Console.WriteLine("Lista Llena");
            }
        }

    }
    class Program
    {
        public static List<ImagenesData> detalles = new List<ImagenesData>();

        public static void GetImageData(string path)
        {
            var image = new Bitmap(path);
            var size = new FileInfo(path).Length;
            var width = image.Width;
            var height = image.Height;
            //finding the name:
            Regex find = new Regex(@"(?<=\\)\S+(?=.png|.jpg)");
            var choosen = find.Match(path).Value;
            var arrOfnames = choosen.Split('\\');
            var realName = arrOfnames[arrOfnames.Length - 1];


            ImagenesData imagenes = new ImagenesData();
            imagenes.Name = realName;
            imagenes.Size = size;
            imagenes.width = width;
            imagenes.height = height;
            detalles.Add(imagenes);
        }


        static void Main(string[] args)
        {
            List<string> myImages = new List<string>();


            Console.WriteLine(@"Ingrese Directorio de imagenes ejm=>C:\Users\Deivi Hernandez\Desktop\Imagenes");
            string directorio = Console.ReadLine();
            foreach (string file in Directory.EnumerateFiles(directorio, "*"))
            {

                myImages.Add(file);
                if (myImages.Count == 700)
                {
                    Console.WriteLine("Capacidad de 700 imagenes completada");
                    break;
                }

            }

            foreach (var path in myImages)
            {
                GetImageData(path);
            }

            Console.Write("Quieres checkear las opciones: SI/NO =>  ");
            string opciones = Console.ReadLine();
            if (opciones.ToUpper() == "SI")
            {
                while (true)
                {
                    Console.WriteLine("Añadir una nueva imagen: 1");
                    Console.WriteLine("ver informacion de imagenes: 2");

                    int oneOrTwo = int.Parse(Console.ReadLine());
                    if (oneOrTwo == 1)
                    {
                        Console.WriteLine(@"Ingrese la direccion de la imagen ejm=>C:\Users\Deivi Hernandez\Desktop\gatito.png");
                        string path = Console.ReadLine();
                        GetImageData(path);
                    }

                    if (oneOrTwo == 2)
                    {
                        foreach (var imagen in detalles)
                        {
                            Console.WriteLine("Name={0}\nSize={1}\nWidth={2}\nHeight={3} ", imagen.Name,
                                imagen.Size, imagen.width, imagen.height);

                            Console.WriteLine("");
                        }
                    }

                    Console.WriteLine("Quieres Salir? SI/NO");
                    string salir = Console.ReadLine();
                    if (salir.ToUpper() == "SI")
                    {
                        break;
                    }
                    Console.Clear();
                }
            }
        }
    }
}
