using System;

class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < numberOfSieves; i++)
        {
            number = number & ~ulong.Parse(Console.ReadLine());
        }
        
        while (number !=0)
        {
            if ((number & 1) == 1)
            {
                count++;
            }
            number >>=  1;
        }
        Console.WriteLine(count);
    }
}
