using System;

public class Exponent : Function
{
    public override double GetValueInX(double x)
    {
        if (x == 0)
        {
            throw new ArgumentException("Function is not defined in point");
        }

        return Math.Exp(1.0 / x);
    }
}
