using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeneradorFormato generador;
            Console.WriteLine("Ingrese el nombre de la imagen:");
            string cNombre = Console.ReadLine();
            mostrarMenu();
            int iOpcion =Convert.ToInt32(Console.ReadLine());
            switch (iOpcion)
            {
                case 1:
                    generador = new FormatoJPGE();
                    break;
                case 2:
                    generador = new FormatoBMP();
                    break;
                case 3:
                    generador = new FormatoPNG();
                    break;
                default:
                    generador = new FormatoPNG();
                    break;
            }
            ProcesadorImagen proc = new ProcesadorImagen(generador);
            proc.procesar(cNombre);
            Console.ReadKey();

        }
        static void mostrarMenu()
        {
            Console.WriteLine("Ingrese una opción para guardar la imagen");
            Console.WriteLine("1 ----------- JGPE");
            Console.WriteLine("2 ----------- BMP");
            Console.WriteLine("3 ----------- PNG");
        }
    }
}
