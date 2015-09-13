using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2

        float x = float.Parse(Console.ReadLine()) - 1;
        float y = float.Parse(Console.ReadLine()) - 1;
        float radius = 1.5f;
        float sum = (x * x + y * y);
        float multiply = radius * radius;
        bool isInside = sum <= multiply && y > 0;
        if (isInside)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        
        Console.WriteLine("--------------");
    }
}

