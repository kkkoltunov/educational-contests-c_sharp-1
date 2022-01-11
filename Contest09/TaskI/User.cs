using System;

public class User
{
    public int Index { get; private set; }
    private string name;

    public User(string name)
    {
        this.name = name;
    }

    public void IncreaseIndex(int count)
    {
        Index = Index + count;
    }
}