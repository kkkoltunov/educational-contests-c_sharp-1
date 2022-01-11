using System;

abstract class Editor
{
    public string name;
    public int salary;

    protected Editor(string name, int salary)
    {
        this.name = name;
        this.salary = salary;
    }

    protected string EditHeader(string header)
    {
        return header;
    }

    public int CountSalary(string oldStr, string newStr)
    {
        int salary = this.salary * Math.Abs(oldStr.Length - newStr.Length);
        return salary;
    }
}