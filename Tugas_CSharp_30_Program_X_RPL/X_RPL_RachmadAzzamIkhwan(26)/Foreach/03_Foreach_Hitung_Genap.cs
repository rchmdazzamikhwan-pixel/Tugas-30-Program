using System;

class Program
{
    static void Main()
    {
        int[] angka = { 2, 5, 8, 9, 10, 13 };
        int jumlahGenap = 0;

        foreach (int nilai in angka)
        {
            if (nilai % 2 == 0)
            {
                jumlahGenap++;
            }
        }

        Console.WriteLine("Banyak bilangan genap = " + jumlahGenap);
    }
}
