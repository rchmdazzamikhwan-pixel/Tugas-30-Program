using System;

class Program
{
    static void Main()
    {
        int[] nilai = new int[5];
        int total = 0;

        for (int i = 0; i < nilai.Length; i++)
        {
            Console.Write("Nilai ke-" + (i + 1) + ": ");
            nilai[i] = Convert.ToInt32(Console.ReadLine());
            total = total + nilai[i];
        }

        double rataRata = (double)total / nilai.Length;
        Console.WriteLine("Rata-rata = " + rataRata);
    }
}
