using System;

public abstract class Function
{
    public static Function GetFunction(string functionName)
    {
        Function function;

        if (functionName == "Sin")
        {
            function = new Sin();
        }
        else if (functionName == "Exp")
        {
            function = new Exponent();
        }
        else if (functionName == "Parabola")
        {
            function = new Parabola();
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return function;
    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        double square = 0;
        double y0 = 0;
        double y1 = 0;

        if (left > right)
        {
            throw new ArgumentException("Left border greater than right");
        }

        while (left + step < right)
        {
            y0 = func.GetValueInX(left);
            y1 = func.GetValueInX(left + step);

            square += ((y0 + y1) / 2) * step;

            left += step;
        }

        y0 = func.GetValueInX(left);
        y1 = func.GetValueInX(right);

        square += ((y0 + y1) / 2) * (right - left);

        return square;
    }
}
