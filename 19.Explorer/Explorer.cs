using System;
using System.Text;
class Explorer
{
    static void Main()
    {
        char star = '*';
        char dash = '-';
        int size = int.Parse(Console.ReadLine());
        string[] diamondParts = new string[size];
        StringBuilder currentLine = new StringBuilder();
        
        for (int i = 0; i <= size / 2; i++)
        {
            currentLine.Clear();
            currentLine.Append(new string(dash, size));
            currentLine.Replace(dash, star, size / 2 - i, 1);
            currentLine.Replace(dash, star, size / 2 + i, 1);
            diamondParts[i] = currentLine.ToString();
            Console.WriteLine(diamondParts[i]);
        }
        for (int i = size/2 -1; i >= 0; i--)
        {
            Console.WriteLine(diamondParts[i]);
        }

       
        
    }
}

