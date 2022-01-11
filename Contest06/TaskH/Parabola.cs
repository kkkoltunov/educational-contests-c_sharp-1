using System;

public class Parabola : Function
{
    public override double GetValueInX(double x)
    {
        return Math.Pow(x, 2) + x + 7;
    }
}
