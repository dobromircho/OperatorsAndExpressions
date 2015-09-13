using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDivided = number % 7 == 0 && number % 5 == 0;
        Console.WriteLine("Divided by 7 and 5: {0}", isDivided);
    }
}

