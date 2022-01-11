using System;
using System.Collections;
using System.Collections.Generic;

public class Army : IEnumerable
{
    int[] soldiers;

    int n;

    public Army(int[] soldiers, int n)
    {
        if (n > soldiers.Length || n < 0)
            throw new ArgumentException("N is not valid");

        this.soldiers = soldiers;
        this.n = n;
    }

    public IEnumerator GetEnumerator()
    {
        List<int> newBuild = new List<int>();

        for (int i = 0; i < soldiers.Length; i++)
        {
            int iter = (n * (i + 1) - 1) % soldiers.Length;
            while (newBuild.Contains(iter)) iter++;
            newBuild.Add(iter);
            yield return soldiers[iter % soldiers.Length];
        }
    }
}