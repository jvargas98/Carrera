using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    class Tortuga:Corredor
    {
        public int comenzar()
        {
            int cantidad = 0;
            int aleat;
            aleat = aleatorio.Next(1, 11);

            if (aleat >= 1 && aleat <= 5)
            {
                cantidad = 3;
            }
            else if (aleat >= 6 && aleat <= 7)
            {
                cantidad = -6;
            }
            else if (aleat >= 8 && aleat <= 10)
            {
                cantidad = 1;
            }

            Avanzar(cantidad);

            return posicionCorredor;
        }
    }
}
