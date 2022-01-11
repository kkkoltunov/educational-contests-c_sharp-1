using System;

public class IntWrapper
{
    private int number;

    public int Number
    {
        get { return number; }
    }

    public IntWrapper(int number)
    {
        this.number = number;
    }

    public uint FindNumberLength()
    {
        if (number < 0)
        {
            throw new ArgumentException("Number should be non-negative.");
        }

        return (uint)Math.Log(number, 10) + 1;
    }
}