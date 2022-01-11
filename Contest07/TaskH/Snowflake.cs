using System;
using System.Text;

public class Snowflake
{
    int snowflakeSquareSize;
    int snowflakeRaysCount;

    public Snowflake(int widthAndHeight, int raysCount)
    {
        if (widthAndHeight <= 0 || widthAndHeight % 2 == 0 || (raysCount & (raysCount - 1)) != 0 || raysCount / 2 < 2)
        {
            throw new ArgumentException("Incorrect input");
        }

        snowflakeSquareSize = widthAndHeight;
        snowflakeRaysCount = raysCount;
    }


    private int RaysPower()
    {
        int power = 0;
        int rays = snowflakeRaysCount;
        while (rays / 2 != 0)
        {
            rays /= 2;
            power++;
        }
        return power;
    }

    private char[,] SnowflakeArray()
    {
        char[,] snowflake = new char[snowflakeSquareSize, snowflakeSquareSize];

        for (int i = 0; i < snowflakeSquareSize; i++)
        {
            if (i != snowflakeSquareSize / 2)
            {
                for (int k = 0; k < snowflakeSquareSize; k++) snowflake[i, k] = ' ';
                snowflake[i, snowflakeSquareSize / 2] = '*';
                //for (int k = 0; k < snowflakeSquareSize; k++) snowflake[i, k] = ' ';
            }
            else for (int k = 0; k < snowflakeSquareSize; k++) snowflake[i, k] = '*';
        }

        int power = RaysPower() - 2;
        int iteration = 0;

        while (power > 0)
        {
            for (int i = snowflakeSquareSize / 2 - 2 * iteration; i >= 0; i--)
            {
                snowflake[snowflakeSquareSize / 2 - (snowflakeSquareSize / 2 - 2 * iteration - i), i] = '*';
                snowflake[snowflakeSquareSize / 2 + (snowflakeSquareSize / 2 - 2 * iteration - i), i] = '*';
            }

            for (int i = snowflakeSquareSize / 2 + 2 * iteration; i < snowflakeSquareSize; i++)
            {
                snowflake[snowflakeSquareSize / 2 - (i - snowflakeSquareSize / 2 - 2 * iteration), i] = '*';
                snowflake[snowflakeSquareSize / 2 + (i - snowflakeSquareSize / 2 - 2 * iteration), i] = '*';
            }

            for (int i = snowflakeSquareSize / 2 - 2 * iteration; i >= 0; i--)
            {
                snowflake[i, snowflakeSquareSize / 2 - (snowflakeSquareSize / 2 - 2 * iteration - i)] = '*';
                snowflake[i, snowflakeSquareSize / 2 + (snowflakeSquareSize / 2 - 2 * iteration - i)] = '*';
            }

            for (int i = snowflakeSquareSize / 2 + 2 * iteration; i < snowflakeSquareSize; i++)
            {
                snowflake[i, snowflakeSquareSize / 2 - (i - snowflakeSquareSize / 2 - 2 * iteration)] = '*';
                snowflake[i, snowflakeSquareSize / 2 + (i - snowflakeSquareSize / 2 - 2 * iteration)] = '*';
            }

            iteration++;
            power--;
        }
        return snowflake;
    }

    public override string ToString()
    {
        char[,] snowflake = SnowflakeArray();
        string[] lines = new string[snowflakeSquareSize];
        for (int i = 0; i < snowflakeSquareSize; i++)
            for (int k = 0; k < snowflakeSquareSize; k++)
                lines[i] += snowflake[i, k] + " ";
        return String.Join('\n', lines);
    }
}