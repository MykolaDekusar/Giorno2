using System;

class Program
{
    static void Main()
    {
        Console.Write("Inserisci il primo numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Inserisci il secondo numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.Write("Scegli l'operazione da fare(+, -, /, *): ");
        string operatore = Console.ReadLine();

    }
}