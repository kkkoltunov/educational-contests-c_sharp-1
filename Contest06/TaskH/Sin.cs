using System;

public class Sin : Function
{
    public override double GetValueInX(double x)
    {
        if (Math.Sin(x) == 0)
        {
            throw new ArgumentException("Function is not defined in point");
        }

        return 1.0 / Math.Sin(x);
    }
}
