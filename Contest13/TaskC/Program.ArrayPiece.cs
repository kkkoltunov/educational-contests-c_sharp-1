using System;
using System.Numerics;

public partial class Program
{
    private static BigInteger[,] GetArrayPart(int x1, int y1, int x2, int y2)
    {
        int[] array1 = new int[] { x2 - x1 + 1, y2 - y1 + 1 };
        int[] array2 = new int[] { x1, y1 };

        BigInteger[,] array = (BigInteger[,])Array.CreateInstance(typeof(BigInteger), array1, array2);

        for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
            {
                BigInteger temp = (BigInteger)i * j;
                array[i, j] = temp;
            }
                
        return array;
    }
}