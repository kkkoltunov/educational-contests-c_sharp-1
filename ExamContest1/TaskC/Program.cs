using System;
using System.Linq;

class Program
{
    static double Funct(double x)
    {
        double prev = 0.1;
        int n = 1;
        double ans = 0;

        double now = Math.Pow(x, 4) / 24;

        ans = now;

        while((prev - now) != 0)
        {
            prev = now;
            now = prev * (-Math.Pow(x, 3)) / ((3 * n + 2) * (3 * n + 3) * (3 * n + 4));
            ans += now;
            n++;
        }
        return ans;
    }
    static void Main(string[] args)
    {
        double x;

        double.TryParse(Console.ReadLine(), out x);

        double ans = Funct(x);

        Console.WriteLine(ans);
    }
}