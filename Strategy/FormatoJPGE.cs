using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class FormatoJPGE:IGeneradorFormato
    {
        public void mostrarFormato(string cNombre)
        {
            Console.WriteLine(string.Format("Se ha guardado la imagen {0}.JPGE", cNombre));
        }
    }
}
