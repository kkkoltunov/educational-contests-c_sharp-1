using System;

public class Vector : IComparable
{
    int x, y;

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Length
    {
        get { return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); }
    }

    internal static Vector Parse(string input)
    {
        string[] inputString = input.Split();

        int x;
        int y;

        if (inputString.Length != 2 || !int.TryParse(inputString[0], out x) || !int.TryParse(inputString[1], out y))
        {
            throw new ArgumentException("Incorrect vector");
        }

        return new Vector(x, y);
    }

    public int CompareTo(object second)
    {
        int i = 0;

        if (this.Length > ((Vector)second).Length)
        {
            i = 1;
        }
        if (this.Length < ((Vector)second).Length)
        {
            i = -1;
        }
        if (this.Length == ((Vector)second).Length)
        {
            i = 0;
        }

        return i;
    }
}