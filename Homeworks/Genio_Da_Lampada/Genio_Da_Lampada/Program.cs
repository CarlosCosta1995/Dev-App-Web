// See https://aka.ms/new-console-template for more information
using Genio_Da_Lampada;

int desejosConsedidos = 0;
LampadaMagica Aladin = new LampadaMagica();

Console.WriteLine("\nQual o número total de desejos quer pedir aos Génios?");
int desejos = int.Parse(Console.ReadLine());
Aladin.Wishes = desejos;
Console.WriteLine(Aladin.Wishes);

while (Aladin.Wishes > 0)
{
    Console.WriteLine("\nInsira o numero de esfregadelas.");
    int esfregar = int.Parse(Console.ReadLine());
    Aladin.Rub(esfregar);

    Aladin.Wishes--;
    desejosConsedidos++;
    Console.WriteLine("Desejos concedidos {0}. Desejos Restantes {1} ", desejosConsedidos, Aladin.Wishes);
}