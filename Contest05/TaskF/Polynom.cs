using System;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {
        bool flag = true;

        string[] lineSplit = line.Split(' ');

        arr = new int[lineSplit.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (!int.TryParse(lineSplit[i], out arr[i]))
            {
                flag = false;
                return flag;
            }
        }

        return flag;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int[] c = new int[Math.Max(a.Length, b.Length)];

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            c[i] += b[i];
        }

        return c;
    }

    public static int[] Dif(int[] a, int[] b)
    {
        int[] c = new int[Math.Max(a.Length, b.Length)];

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            c[i] -= b[i];
        }

        return c;
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] c = new int[a.Length];

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = a[i] * n;
        }

        return c;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length - 1];

        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                for (int k = 0; k < a.Length; k++)
                {
                    int temp = j + k;

                    if (temp == i)
                    {
                        c[i] += a[k] * b[j];
                    }
                }
            }
        }

        return c;
    }

    public static string PolynomToString(int[] polynom)
    {
        string result = "";

        int sum = 0;

        for (int i = 0; i < polynom.Length; i++)
        {
            sum += polynom[i];
        }

        if (sum == 0)
        {
            return "0";
        }

        for (int i = polynom.Length - 1; i != -1; i--)
        {
            if (i == 1 && polynom[i] != 0)
            {
                result += polynom[i].ToString() + "x";
            }
            else if (i == 0 && polynom[i] != 0)
            {
                result += polynom[i].ToString();
            }
            else if (polynom[i] != 0)
            {
                result += polynom[i].ToString() + $"x{i}";
            }
            if (i != 0)
            {
                if (polynom[i - 1] != 0 && result != "")
                {
                    result += " + ";
                }
            }
        }

        return result;
    }
}
