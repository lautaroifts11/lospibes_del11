using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2_materia
{
    internal class Superheroe
    {
        public string nombre;
        public string poder;
        //met. acc //tipo dato // nomb var

        public Arma arma;

        public Superheroe() { }

        public Superheroe(string nombre, string poder, Arma arma)
        {
            this.nombre = nombre;
            this.poder = poder;
            this.arma = arma;
        }

        public virtual void presentarse()
        {
            Console.WriteLine("Hola, soy el superheroe " + this.nombre + " y mi poder secreto es: " + this.poder);
            this.arma.disparar();
        }
    }
}
