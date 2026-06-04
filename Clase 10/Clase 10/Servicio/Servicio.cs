using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    internal class Servicio
    {
        Random azar = new Random();

        public int GenerarNumero()
        {
            int numeroazar = azar.Next(1,101);
            return numeroazar;
        }

    }
}
