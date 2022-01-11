using System;
using System.Collections.Generic;

public class Grassland
{
    List<Sheep> sheeps = new List<Sheep>();

    public Grassland(List<Sheep> sheeps)
    {
        this.sheeps.AddRange(sheeps);
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> sheepsEven = new List<Sheep>();

        for (int i = 0; i < sheeps.Count; i++)
        {
            if (sheeps[i].id % 2 == 0)
            {
                sheepsEven.Add(sheeps[i]);
            }
        }

        return sheepsEven;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> sheepsOdd = new List<Sheep>();

        for (int i = 0; i < sheeps.Count; i++)
        {
            if (sheeps[i].id % 2 == 1)
            {
                sheepsOdd.Add(sheeps[i]);
            }
        }

        return sheepsOdd;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> sheepsName = new List<Sheep>();

        for (int i = 0; i < sheeps.Count; i++)
        {
            if (sheeps[i].name.Contains(name))
            {
                sheepsName.Add(sheeps[i]);
            }
        }

        return sheepsName;
    }
}
