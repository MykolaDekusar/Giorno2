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

        double risultato = 0;
        switch (operatore)
        {
            case "+":
                risultato = numero1 + numero2;
                break;
            case "-":
                risultato = numero1 - numero2;
                break;

            case "*":
                risultato = numero1 * numero2;
                break;

            case "/":
                if (numero2 != 0)
                    risultato = numero1 / numero2;
                else
                {
                    Console.WriteLine("Non puoi dividere per zero!");
                    return; // esce subito dalla funzione
                }
                break;
            default:
                Console.WriteLine("Operazione non riconosciuta.");
                return;
        }
        
        Console.WriteLine($"Il risultato è: {risultato}");
    }
}