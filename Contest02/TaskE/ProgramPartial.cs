using System;

partial class Program
{
    
    static int Factorial(int value)
    {
        int f = 1;

        for (int i = value; i > 1; i--)
        {
            f *= i;
        }

        return f;
    }

    static bool IsInputNumberCorrect(int number)
    {
        return number >= 0;
    }
}