using System;

class PointInACircle
{
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float radius = 2f;
        float sum = (x * x + y * y);
        float multiply = radius * radius;
        bool isInside = sum <= multiply;
        Console.WriteLine(isInside);
    }
}

