namespace Proyect1.DAL.Entities
{
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   
        public DateTime DateBirth { get; set; }
        public string? Region { get; set; }

        public abstract int YearOld(DateTime? year); 
    }
}
