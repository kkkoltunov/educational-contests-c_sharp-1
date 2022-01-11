using System;

delegate double Calculate(int n);

class Program
{
    public static void Main(string[] args)
    {
        Calculate calculate = n =>
        {
            double answer = 0;

            for (double i = 1; i <= 5; i++)
            {
                double result = 1;

                for (double j = 1; j <= 5; j++)
                {
                    result *= ((i + 42) * n) / (j * j);
                }

                answer += result;
            }

            return answer;
        };

        int x;
        int.TryParse(Console.ReadLine(), out x);
        Console.WriteLine(calculate(x).ToString("f3"));
    }
}