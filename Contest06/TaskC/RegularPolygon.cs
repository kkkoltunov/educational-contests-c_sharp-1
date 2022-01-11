using System;

public class RegularPolygon : Polygon
{
    double side { get; set; }
    int numberOfSides { get; set; }

    public RegularPolygon(double side, int numberOfSides)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side length value should be greater than zero.");
        }
        if (numberOfSides < 3)
        {
            throw new ArgumentException("Number of sides value should be greater than 3.");
        }

        this.side = side;
        this.numberOfSides = numberOfSides;
    }

    public override double Perimeter => numberOfSides * side;

    public override double Area => (numberOfSides * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / numberOfSides));

    public override string ToString() => $"side: {side}; numberOfSides: {numberOfSides}; area: {Area:f3}; perimeter: {Perimeter:f3}";
}