using System;

class Program
{
    static void Main()
    {
        int angka = -1;
        int jumlah = 0;

        while (angka != 0)
        {
            Console.Write("Masukkan angka (0 untuk berhenti): ");
            angka = Convert.ToInt32(Console.ReadLine());
            jumlah = jumlah + angka;
        }

        Console.WriteLine("Total = " + jumlah);
    }
}
