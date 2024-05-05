using ConsoleApp7.Entities;

//Variable
int input;

//Si es usuario esta listo
Console.WriteLine("Ready?");
Console.WriteLine();
Console.WriteLine("Escribe para iniciar 1");

//Input
input = int.Parse(Console.ReadLine());
Console.WriteLine();

//Para iniciar el Juego
if (input == 1)
{
    Player player = new Player();
    player.Play();
}

else
{
    Console.WriteLine("Escriba SOLO 1 para iniciar");
}