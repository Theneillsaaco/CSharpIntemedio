namespace Proyect1.DAL.Geometry
{
    public class Triangle : Figure
    {
        public override double calcularArea()
        {
            var A = (h * l) / 2;

            return A;
        }
    }
}
