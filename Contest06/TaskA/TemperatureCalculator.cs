using System;

public static class TemperatureCalculator
{
    public static double FromCelsiusToFahrenheit(double celsiusTemperature)
    {
        double result = 0;

        if (celsiusTemperature >= -273.15)
        {
            result = celsiusTemperature * 1.8 + 32;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

    public static double FromCelsiusToKelvin(double celsiusTemperature)
    {
        double result = 0;

        if (celsiusTemperature >= -273.15)
        {
            result = celsiusTemperature + 273.15;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

    public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
    {
        double result = 0;

        if (fahrenheitTemperature >= -459.67)
        {
            result = (fahrenheitTemperature - 32) / 1.8;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

    public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
    {
        double result = 0;

        if (fahrenheitTemperature >= -459.67)
        {
            result = (fahrenheitTemperature - 32) / 1.8 + 273.15;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

    public static double FromKelvinToCelsius(double kelvinTemperature)
    {
        double result = 0;

        if (kelvinTemperature >= 0)
        {
            result = kelvinTemperature - 273.15;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

    public static double FromKelvinToFahrenheit(double kelvinTemperature)
    {
        double result = 0;

        if (kelvinTemperature >= 0)
        {
            result = (kelvinTemperature - 273.15) * 1.8 + 32;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

        return result;
    }

}
