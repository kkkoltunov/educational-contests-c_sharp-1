using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    public static int SecondInArray(int[] arr)
    {
        int firstMax = int.MinValue;
        int secondMax = int.MinValue;

        if (arr.Length == 1)
        {
            throw new ArgumentException("Not enough elements");
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > secondMax)
            {
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else
                {
                    secondMax = arr[i];
                }
            }
        }

        return secondMax;
    }
}

