using System;

public static class Circle
{
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double Square(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        return Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) - r1 - r2);
    }
}