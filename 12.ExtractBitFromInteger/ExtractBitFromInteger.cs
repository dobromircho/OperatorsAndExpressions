using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p.

        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}

