namespace ConsoleApp11.Entities
{
    public abstract class FiguraGeometrica
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public abstract double CalcularArea();
    }
}
