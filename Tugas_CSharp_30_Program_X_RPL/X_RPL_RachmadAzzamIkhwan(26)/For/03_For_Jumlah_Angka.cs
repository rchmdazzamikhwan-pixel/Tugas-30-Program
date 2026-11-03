using System;

class Program
{
    static void Main()
    {
        int jumlah = 0;

        for (int i = 1; i <= 5; i++)
        {
            jumlah = jumlah + i;
        }

        Console.WriteLine("Jumlah = " + jumlah);
    }
}
