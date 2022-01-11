using System;
using System.Diagnostics.CodeAnalysis;

static class Methods
{
    public static T Max<T>(T a, T b)
    {
        object p1 = a;
        object p2 = b;

        if ((double)p1 > (double)p2)
        {
            return a;
        }
        if ((double)p1 < (double)p2)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
}

