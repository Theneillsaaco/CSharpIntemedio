namespace Proyect1.DAL.Geometry
{
    public class Circulo : Figure
    {
        public override double calcularArea()
        {
            var A = Math.PI * h * h;

            return A;
        }
    }
}
