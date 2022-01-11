using System;

partial class Program
{
    public static double RecurentFunc(double n, int k)
    {
        double result = 0;
        double one = 1;

        if (k == 0)
        {
            return 1;
        }
        else if (k > 0)
        {
            if (k % 2 == 0)
            {
                result = RecurentFunc(n, k / 2);
                return (result * result);
            }
            if (k % 2 == 1)
            {
                result = RecurentFunc(n, k - 1);
                return (n * result);
            }
        }

        return -1;
    }
    public static void Main(string[] args)
    {
        double n;
        int k;

        bool fail = false;

        if (!double.TryParse(Console.ReadLine(), out n))
        {
            fail = true;
        }
        if (!int.TryParse(Console.ReadLine(), out k) || k < 0)
        {
            fail = true;
        }

        double result = 0;

        if (fail == false)
        {
            result = RecurentFunc(n, k);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }

        if (fail == false)
        {
            Console.WriteLine(result);
        }
    }
}   