namespace ConsoleApp6.Entities
{
    public class Clients
    {
        public double Saldo { get; set; }

        public void Depositar (double Monto) 
        {
            Saldo += Monto;
        }

        public void Retirar(double Monto)
        {
            if (Monto > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= Monto;
            }
        }
    }
}
