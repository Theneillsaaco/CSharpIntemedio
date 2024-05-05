namespace ConsoleApp7.Entities
{
    public class Player
    {
        public void Play()
        {
            //Declaracion de variables

            Dado PrimerDado = new Dado();
            Dado SegundoDado = new Dado();
            Dado TrecerDado = new Dado();

            //Imprimir los datos

            Console.WriteLine("Primer dado: {0}", PrimerDado.Valor);
            Console.WriteLine("Segundo dado: {0}", SegundoDado.Valor);
            Console.WriteLine("Tercer dado: {0}", TrecerDado.Valor);

            //Saber si el Jugardor Gano

            if (PrimerDado.Valor == SegundoDado.Valor && PrimerDado.Valor == TrecerDado.Valor)
            {
                Console.WriteLine("Ganaste :D!");
            }

            else
            {
                Console.WriteLine("Perdiste :'(.");
            }

        }
    }
}
