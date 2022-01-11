using System;

class Brigantine : Boat
{
    public Brigantine(int value, bool isAtThePort) : base(value, isAtThePort)
    {        
        Value = value;
        IsAtThePort = isAtThePort;
    }

    public new int CountCost(int weight)
    {
        if (weight <= 500)
        {
            return weight * (int)Math.Pow(Value, 2);
        }

        return Value * weight;
    }
}