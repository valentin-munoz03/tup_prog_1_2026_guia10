using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Servicio
    {
        public Random azar = new Random();
        public int GenerarNumero()
        {
            int NroRandom = azar.Next(1, 101);
            return NroRandom;
        }
    }
}
