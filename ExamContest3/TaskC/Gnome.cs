using System;
using System.Collections.Generic;

public class Gnome
{
    private double weight;
    private int height;

    public static Gnome GetGnome(string[] inputLines, double minWeight, int neededHeight)
    {
        List<Gnome> gnomes = new List<Gnome>();
        List<Gnome> sortedGnomes = new List<Gnome>();
        Gnome gnome = new Gnome(5, 5);

        for (int i = 0; i < inputLines.Length; i++)
        {
            string[] current = inputLines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            gnomes.Add(new Gnome(double.Parse(current[0]), int.Parse(current[1])));
        }

        for (int i = 0; i < gnomes.Count; i++)
            if (gnomes[i].weight > minWeight)
                sortedGnomes.Add(gnomes[i]);

        sortedGnomes.Reverse();

        for (int i = 0; i < sortedGnomes.Count; i++)
            if (sortedGnomes[i].height == neededHeight)
            {
                gnome = sortedGnomes[i];
                break;
            }                

        return gnome;
    }

    private Gnome(double weight, int height)
    {
        if (weight <= 0 || weight > 50)
            throw new ArgumentException("Incorrect weight");

        if (height <= 0 || height >= 100)
            throw new ArgumentException("Incorrect height");

        this.weight = weight;
        this.height = height;
    }

    public override string ToString()
    {
        return $"{weight:f2} {height}";
    }
}