using ConsoleApp12.Interfaces;

namespace ConsoleApp12.Entities
{
    public class Gorrion : IaveBasic
    {
        public void Volar()
        {
            Console.WriteLine("El gorrión vuela");
        }
        public void Cantar()
        {
            Console.WriteLine("El gorrión canta");
        }
        public void PonerHuevos() 
        {
            Console.WriteLine("El gorrión pone huevos");
        }
    }
}
