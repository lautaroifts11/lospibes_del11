namespace parte2_materia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //arreglo de 2 superheroes
            Superheroe[] ligaJusticia = new Superheroe[2];

            //armas - clase aparte -- independi de un superheroe 
            Arma arcoFlecha = new Arma("Arco y flecha", 10);
            Arma boleadora = new Arma("Boleadora", 1000);
            Arma espada = new Arma("Espada tallada por elfos", 1000);
            Arma Revolver = new Arma("Revolver ", 10);

            ligaJusticia[0] = new Superheroe("Patoruzito", "Captura", boleadora);
            ligaJusticia[1] = new Superheroe("Legolass", "Flechazo mistico", arcoFlecha);

            foreach(Superheroe sh in ligaJusticia)
            {
                sh.presentarse();
            }

            
        }
    }
}
