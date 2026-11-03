using System;

class Program
{
    static void Main()
    {
        int[] angka = { 10, 20, 30, 40, 50 };
        Console.Write("Angka yang dicari: ");
        int cari = Convert.ToInt32(Console.ReadLine());
        bool ditemukan = false;

        for (int i = 0; i < angka.Length; i++)
        {
            if (angka[i] == cari)
            {
                ditemukan = true;
            }
        }

        if (ditemukan)
        {
            Console.WriteLine("Angka ditemukan.");
        }
        else
        {
            Console.WriteLine("Angka tidak ditemukan.");
        }
    }
}
