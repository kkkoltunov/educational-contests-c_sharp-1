using System;


class Program
{
    delegate int MyDel(int x);

    static int Method(out int a)
    {
        a = 10;
        return a;
    }

    static void Main(string[] args)
    {
        int a = 5;

        Console.WriteLine(Method(out a));
    }
}
