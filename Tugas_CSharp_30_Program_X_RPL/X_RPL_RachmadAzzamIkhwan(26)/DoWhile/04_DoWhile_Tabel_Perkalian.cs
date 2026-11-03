using System;

class Program
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
            i++;
        }
        while (i <= 10);
    }
}
