using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public class Torre:PiezaAjedrez
    {

        public override string Mover()
        {
            return base.Mover()+ " cualquier cantidad de espacios en una de las 4 direcciones cardinales.";
        }

    }
}
