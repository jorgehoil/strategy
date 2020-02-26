using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    
    public class ProcesadorImagen
    {

        IGeneradorFormato iGeneradorFormato;

        public ProcesadorImagen(IGeneradorFormato iGeneradorFormato)
        {
            this.iGeneradorFormato = iGeneradorFormato;

        }
        public void procesar(string cNombre)
        {
            iGeneradorFormato.mostrarFormato(cNombre);
        }


    }
}
