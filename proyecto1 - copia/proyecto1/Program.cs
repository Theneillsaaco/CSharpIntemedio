using Proyect1.DAL.Entities;
using Proyect1.DAL.Geometry;

#region"Studen"

#region"Date"
var studen = new Studen?[]
{
    //añadiendo a juan
    new Studen {FirstName = "Juan", LastName = "Perez", DateBirth = new DateTime(1999, 12, 31) , Region = "San Juan", Career = "C# Intermedio", Registration = 40 },

    //añadiendo a pepe
    new Studen {FirstName = "Pepe", LastName = "Gonzales", DateBirth = new DateTime(2001, 05, 12) , Region = "La Romana", Career = "C# Intermedio", Registration = 656 }
};

#endregion



//Mostrar la data al usuario

Console.WriteLine("Esto son los datos de Studen:");
Console.WriteLine();

foreach (var student in studen)
{
    if (student is not null) // Verificar valores nulos
    {
        Console.WriteLine($"\t- Nombre: {student.FirstName}");
        Console.WriteLine($"\t- Apellido: {student.LastName}");
        Console.WriteLine($"\t- Años: {student.YearOld(DateTime.Now)}"); 
        Console.WriteLine($"\t- Región: {student.Region}");
        Console.WriteLine($"\t- Carrera: {student.Career}");
        Console.WriteLine($"\t- Matrícula: {student.Registration}");
        Console.WriteLine(); // Agregar una línea en blanco para mejor legibilidad
    }
}

#endregion

#region"Figure :)"

#region"Date"

//Datos de triangulo
var triangulo = new Triangle[]
{
    new Triangle { h = 10, l = 10 },
    new Triangle { h = 10, l = 5}
};

//Dato de circulo
var circulo = new Circulo[]
{
    new Circulo {h = 40},
    new Circulo {h=3}
};

//datos de rectangulo 
var rectagulo = new Rectragle[]
{
    new Rectragle {h = 3, l = 6},
    new Rectragle {h = 10, l = 20}
};

#endregion

//Mostrar datos al usuario

Console.WriteLine();
Console.WriteLine("Esto son los datos de las figura:");
Console.WriteLine();

foreach (var triangulos in triangulo)
{
    if (triangulos is not null) // Verificar valores nulos 
    {
        Console.WriteLine($"\t- Area del triangulo: {triangulos.calcularArea()}");
        Console.WriteLine(); // Agregar una línea en blanco para mejor legibilidad
    }
}

foreach (var circulos in circulo)
{
    if (circulos is not null) // Verificar valores nulos 
    {
        Console.WriteLine($"\t- Area del circulo: {circulos.calcularArea()}");
        Console.WriteLine(); // Agregar una línea en blanco para mejor legibilidad
    }
}

foreach (var rectagulos in rectagulo)
{
    if (rectagulos is not null) // Verificar valores nulos 
    {
        Console.WriteLine($"\t- Area del rectagulo: {rectagulos.calcularArea()}");
        Console.WriteLine(); // Agregar una línea en blanco para mejor legibilidad
    }
}
#endregion

//Habla al usuario
Console.WriteLine();
Console.WriteLine("Esto fue el proyecto :D");