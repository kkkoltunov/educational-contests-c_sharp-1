using System;

public delegate void Calc(ref double x);

class StackCalculator
{
    public static void CreateRules(int[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == 0)
            {
                Program.func += Sinus;
            }
            else if (args[i] == 1)
            {
                Program.func += Cosinus;
            }
            else if (args[i] == 2)
            {
                Program.func += Tangent;
            }
        }
    }

    public static void Tangent(ref double x)
    {
        x = Math.Tan(x);
    }

    public static void Sinus(ref double x)
    {
        x = Math.Sin(x);
    }

    public static void Cosinus(ref double x)
    {
        x = Math.Cos(x);
    }
}