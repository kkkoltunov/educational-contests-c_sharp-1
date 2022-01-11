using System;

public class Citizen : IOptimist, IPessimist
{
    int predictedValue;

    public Citizen(int predictedValue)
    {
        this.predictedValue = predictedValue;
    }

    public double GetForecast()
    {
        return predictedValue * 1.1;
    }

    double IPessimist.GetForecast()
    {
        return predictedValue * 0.6;
    }

    double IOptimist.GetForecast()
    {
        return predictedValue * 2;
    }

    internal static Citizen Parse(string input)
    {
        if (!int.TryParse(input, out int value) || value <= 0)
        {
            throw new ArgumentException("Incorrect citizen");
        }

        return new Citizen(value);
    }
}