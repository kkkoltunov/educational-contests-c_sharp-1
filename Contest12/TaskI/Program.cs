using System;
using System.Diagnostics;

public class Program
{
    // Исользовал ресурс: https://algoprog.ru/material/p2817, https://www.cyberforum.ru/python-beginners/thread2483865.html. 
    public static void Main(string[] args)
    {
        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();

        int[] tshorts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] pants = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int iter1 = 0;
        int iter2 = 0;

        int minTshorts = 0;
        int minPants = 0;

        int tLenght = tshorts.Length;
        int pLenght = pants.Length;

        int minDifference = Math.Abs(tshorts[0] - pants[0]);

        while (iter1 < tLenght && iter2 < pLenght)
        {
            if (tshorts[iter1] == pants[iter2])
            {
                minTshorts = iter1;
                minPants = iter2;
                break;
            }

            int abs = Math.Abs(tshorts[iter1] - pants[iter2]);

            if (abs < minDifference)
            {
                minDifference = abs;
                minTshorts = iter1;
                minPants = iter2;
            }

            if (tshorts[iter1] < pants[iter2])
                iter1++;
            else
                iter2++;
        }

        Console.WriteLine(tshorts[minTshorts] + " " + pants[minPants]);

        //stopwatch.Stop();
        //Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
    }
}