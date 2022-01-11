using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    protected GeometryRef(List<Point> points)
    {
    }

    protected virtual double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSquare()
    {
        throw new NotImplementedException();
    }

    public static GeometryRef Parse(string line)
    {
        string[] inputSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        switch (inputSplit[0])
        {
            case "Triangle":
                if (inputSplit.Length != 7)
                {
                    goto default;
                }
                break;
            case "Rectangle":
                if (inputSplit.Length != 9)
                {
                    goto default;
                }
                break;
            case "GeometryRef":
                if (inputSplit.Length <= 1 && inputSplit.Length % 2 == 0)
                {
                    goto default;
                }
                break;
            default:
                throw new ArgumentException("Incorrect input");
        }

        throw new NotImplementedException();
    }
}