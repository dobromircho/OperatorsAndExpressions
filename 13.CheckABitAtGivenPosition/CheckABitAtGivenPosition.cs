using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool isBitOne = (n & mask) != 0 ? true : false;
        Console.WriteLine(isBitOne);
    }
}