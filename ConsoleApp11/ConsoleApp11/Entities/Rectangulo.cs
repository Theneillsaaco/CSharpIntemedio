namespace ConsoleApp11.Entities
{
    public class Rectangulo : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
