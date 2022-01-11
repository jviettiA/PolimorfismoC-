using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Animal
    {

        public Animal(int Edad, int Altura, int Peso) {
        
            this.Edad = Edad;
            this.Altura = Altura;
            this.Peso = Peso;
        }

        public int Edad { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }

        public virtual string Imprimir() {
        
            return "El animal tiene: "+ Edad+ " años. \nMide: "+Altura+"\nPesa: "+Peso;
        }

        public abstract string Alimento();
    }
}
