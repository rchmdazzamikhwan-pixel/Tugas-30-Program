using System;

class Program
{
    static void Main()
    {
        int[] angka = new int[5];
        int total = 0;

        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write("Masukkan angka ke-" + (i + 1) + ": ");
            angka[i] = Convert.ToInt32(Console.ReadLine());
            total = total + angka[i];
        }

        Console.WriteLine("Jumlah = " + total);
    }
}
