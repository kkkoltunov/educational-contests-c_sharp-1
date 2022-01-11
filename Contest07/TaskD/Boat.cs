using System;

class Boat
{
    public int Value { get; set; }

    public bool IsAtThePort { get; set; }

    public Boat(int value, bool isAtThePort)
    {
        Value = value;
        IsAtThePort = isAtThePort;
    }

    public virtual int CountCost(int weight)
    {
        return Value * weight;
    }
}


