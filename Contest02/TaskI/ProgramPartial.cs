using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

partial class Program
{
    static bool Validate(int a)
    {
        return a >= 0;
    }
    static int GetPerfectNumber(int a)
    {
        int sum = 0;

        for (int j = a; j < 1000000000; j++)
        {
            for (int i = j - 1; i != 0; i--)
            {
                if (j % i == 0)
                {
                    sum += i;
                }
            }

            if (j == sum)
            {
                if (sum >= a)
                {
                    return sum;
                }
            }

            sum = 0;
        }
        
        return 0;
    }
  
}
