partial class Program
 {
     private static double Max(double a, double b)
     {
        double max = 0;

        if (a >= b)
        {
            max = a;
        }
        if (b > a)
        {
            max = b;
        }

        return max;
     }
}