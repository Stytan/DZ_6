using System;

namespace DZ_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Line1 = new Line2D<int>(15, -8, 18, 34);
            var Line2 = new Line2D<double>(
                new Line2D<double>.Point(0.6, -13.4),
                new Line2D<double>.Point(7, -2.3)
                );
            Console.WriteLine(Line1);
            Console.WriteLine(Line2);
        }
    }
}
