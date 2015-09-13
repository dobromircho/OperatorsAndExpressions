using System;

class BitsExchange
{
    static int n = 0;
    static int tempNumber = 0;

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        string entry = (Convert.ToString(n, 2).PadLeft(32, '0'));
        PrintBits(entry, 26, 28, 5, 7);
        tempNumber = n;

        Copy345To242526(1 << 3, 0, 3);
        string result = (Convert.ToString(n, 2).PadLeft(32, '0'));
        
        Copy242526To345(1 << 24, 0, 24);
        result = (Convert.ToString(n, 2).PadLeft(32, '0'));
        PrintBits(result, 5, 7, 26, 28);
        Console.WriteLine(n);
        Console.WriteLine();

    }

    static void Copy242526To345(int mask, int bit, int p)
    {
        for (int i = 0; i < 3; i++)
        {
            mask = 1 << p;
            bit = (tempNumber & mask) != 0 ? 1 : 0;
            if (bit == 1)
            {
                OneInBit(i + 3);
            }
            if (bit == 0)
            {
                ZeroInBit(i + 3);
            }
            p++;
        }
    }

    static void Copy345To242526(int mask, int bit, int p)
    {
        for (int i = 0; i < 3; i++)
        {
            mask = 1 << p;
            bit = (n & mask) != 0 ? 1 : 0;
            if (bit == 1)
            {
                OneInBit(i + 24);
            }
            if (bit == 0)
            {
                ZeroInBit(i + 24);
            }
            p++;
        }
    }

    static void ZeroInBit(int bit)
    {
        n = n & (~(1 << bit));
    }

    static void OneInBit(int bit)
    {
        n = n | (1 << bit);
    }

    static void PrintBits(string number, int start, int end, int start2, int end2)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (i >= start && i <= end)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (i >= start2 && i <= end2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }
}

