using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        string[] inputSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string name = inputSplit[0];
        double weight;
        double diameter;

        if (!double.TryParse(inputSplit[1], out weight) || weight <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        if (!double.TryParse(inputSplit[2], out diameter) || diameter <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        return new Mushroom(name, weight, diameter);
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        double average = 0;
        double y = 0;

        for (int i = 0; i < mushrooms.Count; i++)
        {
            if (mushrooms[i].Weight > m)
            {
                average += mushrooms[i].Diameter;
                y++;
            }
        }

        if (y != 0)
        {
            return average / y;
        }

        return 0;
    }
}