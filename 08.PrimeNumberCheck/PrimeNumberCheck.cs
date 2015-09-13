using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 0)
        {
            isPrime = false;
        }
        else
        {
            for (double i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        Console.WriteLine(isPrime);

    }
}

