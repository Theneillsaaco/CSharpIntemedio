using ConsoleApp12.Interfaces;

namespace ConsoleApp12.Entities
{
    public class Aguila : IaveBasic, IaveCazador
    {
        public void Volar() 
        {
            Console.WriteLine("El águila vuela");
        }
        public void Cantar() 
        { 
            Console.WriteLine("El águila canta"); 
        }
        public void PonerHuevos() 
        { 
            Console.WriteLine("El águila pone huevos");
        }
        public void Cazar()
        { 
            Console.WriteLine("El águila caza"); 
        }
    }
}
