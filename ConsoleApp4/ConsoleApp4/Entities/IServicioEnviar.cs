namespace ConsoleApp4.Entities
{
    public interface IServicioEnviar
    {
        public abstract void EnviarCorreoElectronico(string mensaje);

        public abstract void ImprimirDatos();
    }
}
