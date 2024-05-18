using ConsoleApp12.Interfaces;

namespace ConsoleApp12.Entities
{
    public class Pato : IaveBasic, IaveNadador
    {
        public void Volar() 
        { 
            Console.WriteLine("El pato vuela");
        }
        public void Cantar() 
        {
            Console.WriteLine("El pato canta");
        }
        public void PonerHuevos() 
        {
            Console.WriteLine("El pato pone huevos");
        }
        public void Nadar() 
        {
            Console.WriteLine("El pato nada");
        }
    }
}
