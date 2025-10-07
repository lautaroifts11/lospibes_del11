using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2_materia
{
    internal abstract class Heroe
    {
        public string nombre;
        public Arma arma;

        public Heroe() { }

        public Heroe(string nombre, Arma arma)
        {
            this.nombre = nombre;
            this.arma = arma;
        }

        //metodos abstractos  -- -- -- 

        /* solamente para definir un método pero no implementarlo en la clase abstracta */
        // la clase abstracta puede o no tener metodos abstractaos
        // el metodo abstracto si o si debe estar en una clase abstracta

        //viene la similitud con lo que despues es la interfaz
        public abstract void pelear();

        public virtual void presentarse()
        {
            Console.WriteLine("Hola, soy el heroe " + this.nombre);
            this.arma.disparar();
        }


    }



}
