using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    abstract class Corredor
    {
        protected int posicionCorredor = 0;
        public static Random aleatorio = new Random();

        public int PosicionCorredor { get { return posicionCorredor; } }

        public void Avanzar(int pasos)
        {
            posicionCorredor += pasos;
            if (posicionCorredor < 0)
            {
                posicionCorredor = 0;
            }
        }

        public string mostrar()
        {
            string cadena = "";
            cadena  = "esta en " + posicionCorredor.ToString(); 
            return cadena;
        }

    }
}
