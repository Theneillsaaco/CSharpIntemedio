using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Entities
{
    public class ServicioEnviarPersona : Persona, IServicioEnviar
    {
        public void EnviarCorreoElectronico(string mensaje)
        {
            //x logica para mandar correo electronico
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");

            Console.WriteLine($"Edad: {edad}");

            Console.WriteLine($"Dirección: {direccion}");

            Console.WriteLine($"Correo electrónico: {correoElectronico}");
        }
    }
}
