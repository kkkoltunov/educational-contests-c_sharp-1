using System;

public class MartianInt
{
    private int value;
    private static int count = 0;

    public MartianInt(int value)
    {
        this.value = value;
    }

    public int Value => value;

    public static implicit operator MartianInt(int x)
    {
        MartianInt martianInt = new MartianInt(x - count++);

        if (martianInt.value < 0) throw new ArgumentException("Value is negative");

        return martianInt;
    }

    public static explicit operator int(MartianInt martianInt)
    {
        return martianInt.value + count++;
    }
}