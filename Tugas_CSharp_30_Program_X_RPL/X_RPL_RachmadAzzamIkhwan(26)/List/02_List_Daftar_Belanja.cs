using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> belanja = new List<string>();

        belanja.Add("Buku");
        belanja.Add("Pensil");
        belanja.Add("Penghapus");
        belanja.Add("Penggaris");

        Console.WriteLine("Daftar belanja:");
        foreach (string barang in belanja)
        {
            Console.WriteLine("- " + barang);
        }
    }
}
