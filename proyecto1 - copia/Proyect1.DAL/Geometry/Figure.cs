namespace Proyect1.DAL.Geometry
{
    public abstract class Figure
    {
        public double h {  get; set; }
        public double l { get; set; }
        public abstract double calcularArea();
    }
}
