using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AB + AC + BC;
    }

    public double GetSquare()
    {
        double p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        bool flag = true;

        double res = 0;

        double r1 = Math.Acos(((Math.Pow(BC, 2) + Math.Pow(AB, 2)) - Math.Pow(AC, 2)) / (2 * BC * AB));
        double r2 = Math.Acos(((Math.Pow(BC, 2) + Math.Pow(AC, 2)) - Math.Pow(AB, 2)) / (2 * BC * AC));
        double r3 = Math.Acos(((Math.Pow(AC, 2) + Math.Pow(AB, 2)) - Math.Pow(BC, 2)) / (2 * AC * AB));

        if (AB == BC)
        {
            res = r1;
        }
        if (AC == BC)
        {
            res = r2;
        }
        if (AB == AC)
        {
            res = r3;
        }

        r1 = Math.Round((r1 * 180) / Math.PI);
        r2 = Math.Round((r2 * 180) / Math.PI);
        r3 = Math.Round((r3 * 180) / Math.PI);

        if ((AB == BC) || (AC == BC) || (AB == AC))
        {
            flag = true;
        }
        else
        {
            flag = false;
        }

        angle = res;

        return flag;
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        bool flag = false;

        double max = Math.Max(Math.Max(AB, AC), BC);

        double r1 = Math.Acos(((Math.Pow(BC, 2) + Math.Pow(AB, 2)) - Math.Pow(AC, 2)) / (2 * BC * AB));
        double r2 = Math.Acos(((Math.Pow(BC, 2) + Math.Pow(AC, 2)) - Math.Pow(AB, 2)) / (2 * BC * AC));
        double r3 = Math.Acos(((Math.Pow(AC, 2) + Math.Pow(AB, 2)) - Math.Pow(BC, 2)) / (2 * AC * AB));

        r1 = Math.Round((r1 * 180) / Math.PI);
        r2 = Math.Round((r2 * 180) / Math.PI);
        r3 = Math.Round((r3 * 180) / Math.PI);

        if ((r1 == 90) || (r2 == 90) || (r3 == 90))
        {
            flag = true;
        }

        hypotenuse = max;

        return flag;
    }

    
    private static double GetLengthOfSide(Point first, Point second)
    {
        return Math.Sqrt((Math.Pow(second.GetX() - first.GetX(), 2)) + (Math.Pow(second.GetY() - first.GetY(), 2)));
    }
}