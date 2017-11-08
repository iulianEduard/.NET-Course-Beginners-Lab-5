using System;

namespace Lab5.ConsoleApp.Encapsulation
{
    public class Point
    {
        public int X { get; set; } = 1;

        public int Y { get; set; } = 1;

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"[{X}, {Y}]");
        }
    }
}
