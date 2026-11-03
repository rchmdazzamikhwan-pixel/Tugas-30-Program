using System;

class Program
{
    static void Main()
    {
        string[] nama = { "Andi", "Budi", "Citra", "Dani" };
        string cari = "Citra";
        bool ditemukan = false;

        foreach (string orang in nama)
        {
            if (orang == cari)
            {
                ditemukan = true;
            }
        }

        if (ditemukan)
        {
            Console.WriteLine(cari + " ditemukan.");
        }
        else
        {
            Console.WriteLine(cari + " tidak ditemukan.");
        }
    }
}
