namespace ConsoleApp11.Entities
{
    public class Cuadrado : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            // ¡Error! Devuelve el area de un rectángulo
            return Base * Altura;
        }
    }
}
