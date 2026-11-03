using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> nilai = new List<int>();

        nilai.Add(80);
        nilai.Add(90);
        nilai.Add(75);
        nilai.Add(85);

        int total = 0;

        foreach (int angka in nilai)
        {
            total = total + angka;
        }

        double rataRata = (double)total / nilai.Count;
        Console.WriteLine("Rata-rata = " + rataRata);
    }
}
