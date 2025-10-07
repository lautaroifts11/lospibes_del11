using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2_materia
{
    internal class HeroeMitologico: Heroe
    {
        public string origen;
        public string atributo;

        public HeroeMitologico(){}

        public HeroeMitologico(string nombre, Arma arma, string origen, string atributo): base(nombre, arma)
        {
            this.origen = origen;
            this.atributo = atributo;
        }

        public override void presentarse()
        {
            base.presentarse();
            Console.WriteLine("Mi origen es: "+ this.origen+ " y mi atributo divino es: "+ this.atributo);
        }

        public override void pelear()
        {
            Console.WriteLine("Heroe mitologico peleando");  
        }
    }
}
