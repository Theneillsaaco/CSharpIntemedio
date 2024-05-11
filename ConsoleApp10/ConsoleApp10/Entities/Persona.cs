using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp10.Entities
{
    public class Persona
    {
        public string Name { get; set; }
        public int Edad {  get; set; }

        public void ImprimirPersona()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}
