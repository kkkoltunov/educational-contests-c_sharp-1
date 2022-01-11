using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        int n = 0;

        string[] sheepSettings = line.Split(' ');

        if (!int.TryParse(sheepSettings[4], out n) || n <= 0 || n >= 1000)
        {
            throw new ArgumentException("Incorrect input");
        }

        Sheep sheep = new Sheep(n, sheepSettings[1], sheepSettings[6]);

        return sheep;
    }
}
