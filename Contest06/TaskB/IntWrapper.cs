using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    int number { get; set; }

    public IntWrapper(int number)
    {
        this.number = number;
    }

    public int FindNumberLength()
    {
        string result;

        if (number < 0)
        {
            throw new ArgumentException("Number should be non-negative.");
        }
        else
        {
            result = number.ToString();
        }

        return result.Length;
    }
}
