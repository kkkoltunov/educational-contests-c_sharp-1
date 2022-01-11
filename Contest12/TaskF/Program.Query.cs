using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        var selectedCats = cats.Where(c => (c.IsBlack && c.TailLength >= minTailLength && c.TailLength <= maxTailLength && c.Age <= maxAge) || c.TailLength == cats.Max(c => c.TailLength)).ToList();
        return selectedCats;
    }
}