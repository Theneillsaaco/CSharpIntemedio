namespace ConsoleApp6.Entities
{
    public class Banco
    {
        private Clients client1;
        private Clients client2;
        private Clients client3;

        public Banco()
        {
            client1 = new Clients();
            client2 = new Clients();
            client3 = new Clients();
        }

        public void RealizarOperaciones()
        {
            // Simular operaciones de los clientes
            client1.Depositar(100);
            client2.Depositar(1000);
            client3.Depositar(200);
            client2.Retirar(150);
        }

        public void CalcularSaldoTotal()
        {
            double saldoTotal = client1.Saldo + client2.Saldo + client3.Saldo;
            Console.WriteLine("Saldo total al final del día: {0}", saldoTotal);
        }
    }
}
