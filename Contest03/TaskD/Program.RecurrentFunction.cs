using System;

partial class Program
{
    private static bool Validate(string input, out int num)
    {
        bool temp = true;

        if (!int.TryParse(input, out num) || num < 0)
        {
            temp = false;
        }

        return temp;
    }

    private static int RecurrentFunction(int n)
    {
        n = (2 * RecurrentFunction(n - 1) + 1);

        return n;
    }
}