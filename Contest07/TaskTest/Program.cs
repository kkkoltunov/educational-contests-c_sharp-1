using System;
class A
{
    public int x;
    public A(int x)
    {
        this.x = x;
    }
}
class Program
{
    static void Main()
    {
        A a = new A() { x = 10 };
        a.x++;
        Console.Write(a.x);
    }
}
