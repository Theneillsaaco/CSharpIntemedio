namespace ConsoleApp10.Entities
{
    public class Empleado : Persona
    {
        public double Sueldo { get; set; }

        public void ImprimirSueldo()
        {
            Console.WriteLine($"El sueldo es: {Sueldo}");
        }
    }
}
