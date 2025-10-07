using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2_materia
{
    internal class Superheroe: Heroe
    {

        public string poder;
        //met. acc //tipo dato // nomb var
        public Superpoder superpoder;

        public Superheroe() {
            this.superpoder = new Superpoder();
        }

        public Superheroe(string nombre, string poder, Arma arma, string superpower) : base(nombre, arma)
        {
            this.poder = poder;
            this.superpoder= new Superpoder(superpower);
        }

        public override void presentarse()
        {
            base.presentarse();
            Console.WriteLine("mi poder secreto es: " + this.poder+ " y mi superpoder es: "+ this.superpoder.nombre);
        }

        public override void pelear()
        {
            Console.WriteLine("Superheroe peleando");
        }
    }
}
