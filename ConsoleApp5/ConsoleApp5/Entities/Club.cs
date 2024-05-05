namespace ConsoleApp5.Entities
{
    public class Club
    {
        private Socios socio1;
        private Socios socio2;
        private Socios socio3;

        public Club(Socios socio1, Socios socio2, Socios socio3)
        {
            this.socio1 = socio1;
            this.socio2 = socio2;
            this.socio3 = socio3;
        }

        public void PrintSocioOld()
        {
            Socios socioMayor = socio1;

            if (socio2.GetOld() > socioMayor.GetOld())
            {
                socioMayor = socio2;
            }

            if (socio3.GetOld() > socioMayor.GetOld())
            {
                socioMayor = socio3;
            }

            Console.WriteLine("El socio con mayor antigüedad es: " + socioMayor.GetName() + " con " + socioMayor.GetOld() + " años.");
        }
    }
}
