using System;

public class Worker
{
    Apple[] apples;

    public Worker(Apple[] apples)
    {
        this.apples = apples;
    }

    public Apple[] GetSortedApples()
    {
        Array.Sort(apples, (el1, el2) =>
        {
            if (el1.Weight > el2.Weight) return 1;
            if (el1.Weight < el2.Weight) return -1;
            return 0;
        });

        return apples;
    }
}