namespace ConsoleApp7.Entities
{
    public class Dado
    {
        public int Valor { get; private set; }

        public Dado()
        {
            Random random = new Random();
            Valor = random.Next(1, 7);
        } 
    }
}
