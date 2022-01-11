using System;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        bool flag = true;

        string[] lineSplit = line.Split(' ');

        arr = new int[lineSplit.Length];

        for (int i = 0; i < lineSplit.Length; i++)
        {
            if (!int.TryParse(lineSplit[i], out arr[i]))
            {
                flag = false;
            }
        }

        return flag;
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        int[] arrCopy = new int[right - left];

        int i = 0;
        int j = 0;
        int k = 0;

        while (left + i < mid && mid + j < right)
        {
            if (arr[left + i] > arr[mid + j])
            {
                arrCopy[k++] = arr[mid + j++];
            }
            else
            {
                arrCopy[k++] = arr[left + i++];
            }
        }

        while (left + i < mid)
        {
            arrCopy[k++] = arr[left + i++];
        }
        while (mid + j < right)
        {
            arrCopy[k++] = arr[mid + j++];
        }

        k = 0;

        for (int z = left; z < right; z++)
        {
            arr[z] = arrCopy[k++];
        }
    }
}