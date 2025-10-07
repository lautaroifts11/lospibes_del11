namespace parte2_materia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pasamos a listas
            List<Superheroe> ligaJusticiaMultiverso= new List<Superheroe>();


            //armas - clase aparte -- independi de un superheroe 
            Arma arcoFlecha = new Arma("Arco y flecha", 10);
            Arma boleadora = new Arma("Boleadora", 1000);
            Arma espada = new Arma("Espada tallada por elfos", 1000);
            Arma revolver = new Arma("Revolver ", 10);
            Arma batiprofeno = new Arma("BatiProfeno", 100);

            Superheroe patoruzito = new Superheroe("Patoruzito", "Captura", boleadora, "SuperCaptura");

            ligaJusticiaMultiverso.Add(patoruzito);
            ligaJusticiaMultiverso.Add(new Superheroe("Legolass", "Flechazo mistico", arcoFlecha, "Superflecha"));
            ligaJusticiaMultiverso.Add(new Superheroe("Bataman", "batisanar", batiprofeno, "SuperSanar"));

            //eliminar elementos de una lista por indice
            ligaJusticiaMultiverso.RemoveAt(2);

            // eliminar elementos de una lista por objetos
            //ligaJusticiaMultiverso.Remove(patoruzito);
            

            //foreach (Superheroe sh in ligaJusticiaMultiverso)
            //{
            //    sh.presentarse();
            //}

            // lista de heroes (que es clase abstracta)
            List<Heroe> snkvscapcom = new List<Heroe>();
            snkvscapcom.Add(new Superheroe("Patoruzito", "Captura", boleadora, "SuperCaptura"));
            snkvscapcom.Add(new Superheroe("Legolass", "Flechazo mistico", arcoFlecha, "Superflecha"));
            snkvscapcom.Add(new Superheroe("Bataman", "batisanar", batiprofeno, "SuperSanar"));
            snkvscapcom.Add(new HeroeMitologico("Kratos", espada, "Espartano", "Dios de la guerra"));
            snkvscapcom.Add(new HeroeMitologico("Hades", revolver, "Griego", "Dios del infierno"));

            foreach(Heroe heroe in snkvscapcom)
            {
                heroe.presentarse();
                heroe.pelear();
                Console.WriteLine("");
            }

        }
    }
}
