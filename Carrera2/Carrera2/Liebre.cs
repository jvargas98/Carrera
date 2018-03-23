using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera2
{
    class Liebre:Corredor
    {
        public int comenzar()
        {
            int cantidad = 0;
            int aleat;
            aleat = aleatorio.Next(1, 11);

            if (aleat >= 1 && aleat <= 2)
            {
                cantidad = 0;
            }
            else if (aleat >= 3 && aleat <= 4)
            {
                cantidad = 9;
            }
            else if (aleat == 5)
            {
                cantidad = -12;
            }
            else if (aleat >= 6 && aleat <= 8)
            {
                cantidad = 1;
            }
            else if (aleat >= 9 && aleat <= 10)
            {
                cantidad = -2;
            }

            Avanzar(cantidad);

            return posicionCorredor;
        }
    }
}
