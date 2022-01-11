using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static bool Validate(int n)
    {
        return n >= 0;
    }

    static int DivisorsSum(int n)
    {
        int sum = 0;

        for (int i = n - 1; i > 0; i--)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}
