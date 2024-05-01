namespace ConsoleApp4.Interfaces
{
    public interface IServicioEnviar
    {
        public abstract void EnviarCorreoElectronico(string mensaje);
        public abstract void ImprimirDatos();
    }
}