using System;

class Program
{
    static void Main()
    {
        int angka;
        int total = 0;

        do
        {
            Console.Write("Masukkan angka (0 untuk selesai): ");
            angka = Convert.ToInt32(Console.ReadLine());
            total = total + angka;
        }
        while (angka != 0);

        Console.WriteLine("Total = " + total);
    }
}
