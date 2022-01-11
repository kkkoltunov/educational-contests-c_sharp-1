using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        List<Point> points = new List<Point>();

        string[] input = File.ReadAllLines(InputPath);

        for (int i = 0; i < input.Length; i++)
        {
            string[] inputSplit = input[i].Split(" ");

            int x = int.Parse(inputSplit[0]);
            int y = int.Parse(inputSplit[1]);
            int z = int.Parse(inputSplit[2]);

            points.Add(new Point(x, y, z));
        }

        return points;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> pointsHash = new HashSet<Point>();

        for (int i = 0; i < points.Count; i++)
        {
            if (!pointsHash.Contains(points[i]))
            {
                pointsHash.Add(points[i]);
            }
        }

        return pointsHash;
    }
}