using System;
using System.IO;

public class Summator
{
    int sum;

    public Summator(string path)
    {
        string[] data = File.ReadAllLines(path);

        for (int i = 0; i < data.Length; i++)
        {
            string[] current = data[i].Split('_', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < current.Length; j++)
            {
                sum += int.Parse(current[j]);
            }
        }
    }

    public int Sum
    {
        get
        {
            return sum;
        }
    }
}