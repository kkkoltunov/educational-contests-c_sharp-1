using System;

public class Content
{
    protected int size;
    protected string name;

    public Content(int size, string name)
    {
        this.size = size;
        this.name = name;
    }

    public int Size
    {
        get { return size; }
    }
}