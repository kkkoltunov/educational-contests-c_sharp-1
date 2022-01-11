using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Point> points = new List<Point>();

        int nearestCount = int.Parse(Console.ReadLine());
        int countPoints = int.Parse(Console.ReadLine());

        for (int i = 0; i < countPoints; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            points.Add(new Point(int.Parse(data[0]), int.Parse(data[1])));
        }

        points.Sort(new PointDistance());

        //Console.WriteLine("-----");
        //foreach(var el in points)
        //    Console.WriteLine(el);
        //Console.WriteLine("-----");

        List<Point> pointsNew = new List<Point>();

        for (int i = 0; i < nearestCount; i++)
            pointsNew.Add(points[i]);

        for (int i = nearestCount; i < countPoints; i++)
            if (points[nearestCount - 1].Distance() == points[i].Distance())
                pointsNew.Add(points[i]);

        pointsNew.Sort(new PointCoordinates());

        for (int i = 0; i < nearestCount; i++)
            Console.WriteLine(pointsNew[i]);
    }

    class PointDistance : IComparer<Point>
    {
        public int Compare(Point point1, Point point2)
        {
            if (point1.Distance() > point2.Distance()) return 1;
            if (point1.Distance() < point2.Distance()) return -1;

            return 0;
        }
    }

    class PointCoordinates : IComparer<Point>
    {
        public int Compare(Point point1, Point point2)
        {
            if (point1.X > point2.X)
                return 1;            
            if (point1.X < point2.X)
                return -1;
            if (point1.X == point2.X)
            {
                if (point1.Y > point2.Y)
                    return 1;
                if (point1.Y < point2.Y)
                    return -1;
            }
                           
            return 0;
        }
    }

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Distance()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}