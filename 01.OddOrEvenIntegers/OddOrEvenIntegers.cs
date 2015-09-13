using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool odd = n % 2 == 0;
        Console.WriteLine("Odd: {0}", !odd);
    }
}

