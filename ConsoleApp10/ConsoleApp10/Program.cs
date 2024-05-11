using ConsoleApp10.Entities;

Persona persona = new Persona();
Empleado empleado1 = new Empleado();

#region"Datos"

//Datos de persona
persona.Name = "Juan Perez";
persona.Edad = 28;

//Datos de Empleado
empleado1.Name = "Ana López";
empleado1.Edad = 25;
empleado1.Sueldo = 2500.00;

#endregion

//imprimir las clases
persona.ImprimirPersona();

Console.WriteLine();

empleado1.ImprimirPersona();
empleado1.ImprimirSueldo();