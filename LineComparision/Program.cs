using System;
namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Line Comparision Computation");
            Console.WriteLine("===========================================");
            Point line1Start = new Point();
            Point line1End = new Point();
            Point line2Start = new Point();
            Point line2End = new Point();
            Console.WriteLine("For First Line");
            StorePoints(ref line1Start, ref line1End);
            Line line1 = new Line(line1Start, line1End);
            Console.WriteLine("For Second Line");
            StorePoints(ref line2Start, ref line2End);
            Line line2 = new Line(line2Start, line2End);
            Console.WriteLine("Length of first line is " + line1.Length);
            Console.WriteLine("Length of first line is " + line2.Length);
            if (line1.Length.CompareTo(line2.Length) == 0)
                Console.WriteLine("Both lines have equal length");
            else if (line1.Length.CompareTo(line2.Length) > 0)
                Console.WriteLine("First line is longer than the second one");
            else
                Console.WriteLine("First line is sorter than the second one");
            return;
        }
        static void StorePoints(ref Point p1, ref Point p2)
        {
            Console.WriteLine("Enter X-Coordinate of start point");
            p1.X = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Coordinate of start point");
            p1.Y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter X-Coordinate of end point");
            p2.X = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Coordinate of end point");
            p2.Y = Int32.Parse(Console.ReadLine());
            return;
        }
    }
}