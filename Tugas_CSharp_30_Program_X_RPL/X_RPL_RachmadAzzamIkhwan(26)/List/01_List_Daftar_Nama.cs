using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nama = new List<string>();

        nama.Add("Andi");
        nama.Add("Budi");
        nama.Add("Citra");

        foreach (string orang in nama)
        {
            Console.WriteLine(orang);
        }
    }
}
