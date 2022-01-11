using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public abstract class PiezaAjedrez
    {
        public virtual string Mover() {

            return "La pieza se mueve: ";
        }
    }
}
