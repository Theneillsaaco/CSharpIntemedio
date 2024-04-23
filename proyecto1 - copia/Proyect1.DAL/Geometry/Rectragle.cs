namespace Proyect1.DAL.Geometry
{
    public class Rectragle : Figure
    {
        public override double calcularArea()
        {
            var A = h * l;

            return A;
        }
    }
}
