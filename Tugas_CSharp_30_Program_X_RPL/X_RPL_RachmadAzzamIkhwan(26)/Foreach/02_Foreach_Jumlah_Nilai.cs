using System;

class Program
{
    static void Main()
    {
        int[] nilai = { 80, 75, 90, 85 };
        int total = 0;

        foreach (int angka in nilai)
        {
            total = total + angka;
        }

        Console.WriteLine("Total nilai = " + total);
    }
}
