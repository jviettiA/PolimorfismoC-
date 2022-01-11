using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Peon:PiezaAjedrez
    {

        public override string Mover()
        {
            return base.Mover() + " 1 espacio para adelante o 2 espacios para adelante si es su primer movimiento.";
        }
    }
}
