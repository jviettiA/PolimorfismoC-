using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public class Loro:Animal
    {
        public Loro(int Edad, int Altura, int Peso, string Nombre) : base(Edad, Peso, Altura)
        {

            this.Nombre = Nombre;
        }

        public string Nombre { get; set; }

        public override string Imprimir()
        {
            return base.Imprimir() + "\nSe llama: " + Nombre;
        }
        public override string Alimento()
        {
            return "Come comida de loro.";
        }
    }
}
