using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2_materia
{
    internal class Arma
    {
        public string nombre;
        public int cant_disparos;

        public Arma() { }
        public Arma(string nombre, int cant_disparos)
        {
            this.nombre = nombre;
            this.cant_disparos = cant_disparos;
        }

        public void disparar()
        {
            Console.WriteLine(" Disparo "+this.cant_disparos +" con la : "+ this.nombre);
        }
    }
}
