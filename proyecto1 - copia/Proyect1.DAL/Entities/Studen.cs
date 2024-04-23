namespace Proyect1.DAL.Entities
{
    public class Studen : Person
    {
        public string Career {  get; set; }
        public int Registration { get; set; }

        public override int YearOld(DateTime? year)
        {
            var Year = DateTime.Now.Year - DateBirth.Year;

            return Year;
        }
    }
}
