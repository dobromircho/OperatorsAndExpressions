using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("0 or 1: ");
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            n = n & (~(1 << p));
        }
        if (v == 1)
        {
            n = n | (1 << p);
        }
        Console.WriteLine("Result Integer: {0}", n);

    }
}

