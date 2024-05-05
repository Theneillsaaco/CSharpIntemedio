namespace ConsoleApp5.Entities
{
    public class Socios
    {
        private string? Name { get; set; }
        private int Old { get; set; }

        public void Socio(string name, int old)
        {
            this.Name = name;
            this.Old = old;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetOld()
        {
            return Old;
        }
    }
}
