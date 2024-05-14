namespace ConsoleApp9.Entities
{
    public class TaxCalculator
    {
        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxAmount = 0;

            Dictionary<string, decimal> taxRates = new Dictionary<string, decimal>();

            //Paises y impuestos
            taxRates.Add("India", 0.30m);
            taxRates.Add("USA", 0.25m);
            taxRates.Add("UK", 0.20m);

            decimal taxableIncome = income - deduction;

            if (taxRates.ContainsKey(country))
            {
                taxAmount = taxableIncome * taxRates[country];
            }
            else
            {
                Console.WriteLine("El país no está admitido");
            }

            return taxAmount;
        }
    }
}
