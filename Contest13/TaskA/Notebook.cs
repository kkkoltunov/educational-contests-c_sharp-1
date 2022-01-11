using System;

public class Notebook : Product
{
    private readonly string color;
    long id;
    
    public Notebook(long id, string color) : base(id)
    {
        this.id = id;
        this.color = color;
    }

    public override string ToString() => $"Product. Id = {id}. Type = Notebook. Color = {color}";
}