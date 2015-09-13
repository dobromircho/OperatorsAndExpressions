using System;

class FourDigitNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        int sum = 0;
        // Sum
        for (int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i].ToString());
        }
        Console.WriteLine("Sum: {0}", sum);
        // Reversed
        Console.Write("Reversed: ");
        for (int i = number.Length-1; i >=0; i--)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
        // First digit infront
        char[] digits = new char[number.Length];
        char last = number[number.Length - 1];
        digits[0] = last;

        for (int i = 1; i < number.Length; i++)
        {
            digits[i] = number[i - 1];
        }
        Console.Write("Last digit in front: ");

        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
        //Exchange second and third digit
        if (number.Length == 4)
        {
            char[] exchange = new char[number.Length];
            exchange[0] = number[0];
            exchange[1] = number[2];
            exchange[2] = number[1];
            exchange[3] = number[3];
            Console.Write("Exchange second and third: ");

            for (int i = 0; i < exchange.Length; i++)
            {
                Console.Write(exchange[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Incorrect Number");
        }
    }
}

