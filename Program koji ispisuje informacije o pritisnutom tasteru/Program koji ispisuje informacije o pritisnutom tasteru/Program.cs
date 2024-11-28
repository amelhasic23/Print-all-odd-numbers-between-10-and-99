using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pritisnite taster (ili ESC za izlaz):");

        ConsoleKeyInfo taster;
        do
        {
            taster = Console.ReadKey(true); // Čita pritisnut taster
            Console.WriteLine($"Pritisnuti taster: {taster.Key}, Karakter: {taster.KeyChar}, Modifikator: {taster.Modifiers}");
        } while (taster.Key != ConsoleKey.Escape); // Prekida kada se pritisne ESC
    }
}
