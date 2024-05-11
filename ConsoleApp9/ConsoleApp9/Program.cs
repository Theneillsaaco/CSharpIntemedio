using ConsoleApp9.Entities;

//Test

TaxCalculator taxCalculator = new TaxCalculator();


#region"Datos"

decimal income = 50000m;
decimal deduction = 10000m;
string country = "India";

#endregion

decimal taxAmount = taxCalculator.Calculate(income, deduction, country);
Console.WriteLine($"Impuesto a pagar: {taxAmount}");

