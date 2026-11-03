using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> barang = new List<string>();

        barang.Add("Laptop");
        barang.Add("Mouse");
        barang.Add("Keyboard");

        if (barang.Contains("Mouse"))
        {
            Console.WriteLine("Mouse tersedia.");
        }
        else
        {
            Console.WriteLine("Mouse tidak tersedia.");
        }
    }
}
