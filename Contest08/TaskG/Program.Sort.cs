using System;

partial class Program
{
    internal static int[] StrangeSort(int[] arr)
    {
        int[] arrSort = new int[arr.Length];

        for (int i = 0; i < arrSort.Length; i++)
        {
            int temp = arr[i];
            arrSort[i] = temp;
        }

        Array.Sort(arrSort, (int x, int y) =>
        {
            if ((Math.Log10(x) + 1) > (Math.Log10(y) + 1)) return 1;
            else if ((Math.Log10(x) + 1) < (Math.Log10(y) + 1)) return -1;
            else return 0;
        });

        return arrSort;
    }
}