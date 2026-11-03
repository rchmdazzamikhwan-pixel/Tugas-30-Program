using System;

class Program
{
    static void Main()
    {
        int i = 1;
        int jumlah = 0;

        while (i <= 5)
        {
            jumlah = jumlah + i;
            i++;
        }

        Console.WriteLine("Jumlah = " + jumlah);
    }
}
