using System;

class Program
{
    static void Main()
    {
        int pilihan;

        do
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Halo");
            Console.WriteLine("2. Selamat belajar");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih menu: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("Halo!");
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Semangat belajar C#!");
            }
        }
        while (pilihan != 3);

        Console.WriteLine("Program selesai.");
    }
}
