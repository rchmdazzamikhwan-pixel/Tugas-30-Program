using System;

class Program
{
    static void Main()
    {
        string[] buah = { "Apel", "Jeruk", "Mangga", "Pisang" };

        foreach (string item in buah)
        {
            Console.WriteLine("Saya suka " + item);
        }
    }
}
