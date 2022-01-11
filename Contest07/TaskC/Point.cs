using System;

public class Point
{
    int x;
    int y;
    int z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override bool Equals(object obj) => obj != this;

    public override int GetHashCode() => x + y + z;

    public override string ToString() => $"{x} {y} {z}";
}