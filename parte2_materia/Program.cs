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
            Arma Revolver = new Arma("Revolver ", 10);
            Arma batiprofeno = new Arma("BatiProfeno", 100);

            Superheroe patoruzito = new Superheroe("Patoruzito", "Captura", boleadora);

            ligaJusticiaMultiverso.Add(patoruzito);
            ligaJusticiaMultiverso.Add(new Superheroe("Legolass", "Flechazo mistico", arcoFlecha));
            ligaJusticiaMultiverso.Add(new Superheroe("Bataman", "batisanar", batiprofeno));

            //eliminar elementos de una lista por indice
            ligaJusticiaMultiverso.RemoveAt(2);

            // eliminar elementos de una lista por objetos
            //ligaJusticiaMultiverso.Remove(patoruzito);
            ligaJusticiaMultiverso.RemoveAll();

            foreach (Superheroe sh in ligaJusticiaMultiverso)
            {
                sh.presentarse();
            }

            
        }
    }
}
