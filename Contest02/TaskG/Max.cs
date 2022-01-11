using System;

partial class Program
{

    private static double MaxOfThree(double a, double b, double c)
    {
        return Math.Max(Math.Max(a, b), c);
    }
}