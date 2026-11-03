using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(angka + " x " + i + " = " + (angka * i));
        }
    }
}
