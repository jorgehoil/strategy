using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class FormatoBMP : IGeneradorFormato
    {
        public void mostrarFormato(string cNombre)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.BMP", cNombre));
        }
    }
}
