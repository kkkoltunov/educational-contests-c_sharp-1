using System;

public class Apple
{
    double weight;
    string color;

    public double Weight
    {
        get 
        {
            return weight;
        }
        set 
        {
            if (value > 0 && value <= 1000)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }
    }
    public string Color
    {
        get 
        {
            return color;
        }
        set 
        {
            if (value.Length <= 5 && value[0] >= 65 && value[0] <= 90)
            {
                color = value;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }
    }

    public override string ToString()
    {
        return $"{color} Apple. Weight = {weight:f2}g.";
    }
}