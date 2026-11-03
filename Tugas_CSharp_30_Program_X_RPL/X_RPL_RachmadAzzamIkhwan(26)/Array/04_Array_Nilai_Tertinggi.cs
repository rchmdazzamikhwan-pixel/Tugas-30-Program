using System;

class Program
{
    static void Main()
    {
        int[] nilai = new int[5];

        for (int i = 0; i < nilai.Length; i++)
        {
            Console.Write("Masukkan nilai ke-" + (i + 1) + ": ");
            nilai[i] = Convert.ToInt32(Console.ReadLine());
        }

        int tertinggi = nilai[0];

        for (int i = 1; i < nilai.Length; i++)
        {
            if (nilai[i] > tertinggi)
            {
                tertinggi = nilai[i];
            }
        }

        Console.WriteLine("Nilai tertinggi = " + tertinggi);
    }
}
