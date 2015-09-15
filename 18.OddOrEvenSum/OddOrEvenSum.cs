using System;

class OddOrEvenSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        for (int i = 0; i < number; i++)
        {
            oddSum += int.Parse(Console.ReadLine());
            evenSum += int.Parse(Console.ReadLine());
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
        
    }
}

