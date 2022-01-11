using System;
using System.Linq;

internal class ChristmasArray : BaseArray
{

    public ChristmasArray(int[] array) : base(array)
    {
    }
    public override int this[int number]
    {
        get
        {
            bool flag = false;

            int[] arrayNew = new int[array.Length];

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < number)
                {
                    arrayNew[k++] = array[i];
                    flag = true;
                }
            }

            if (flag == false)
            {
                throw new ArgumentException("Number does not exist.");
            }

            Array.Sort(arrayNew);
            return arrayNew[arrayNew.Length - 1];
        }
    }

    public override double GetMetric()
    {
        double count = 0;

        string line = string.Join("", array);

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '6')
            {
                count++;
            }
        }

        return count / line.Length;
    }
}