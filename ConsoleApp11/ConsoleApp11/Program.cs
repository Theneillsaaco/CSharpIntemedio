using ConsoleApp11.Entities;

FiguraGeometrica figura1 = new Rectangulo() { Base = 5, Altura = 3 };
FiguraGeometrica figura2 = new Cuadrado() { Base = 5, Altura = 3};

Console.WriteLine($"Área del rectángulo: {figura1.CalcularArea()}");
Console.WriteLine($"Área del cuadrado: {figura2.CalcularArea()}");