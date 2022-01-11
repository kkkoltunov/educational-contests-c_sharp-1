using System;

[Serializable]
public class Ash : Tree
{
    public int leafCount;

    public Ash()
    {
    }

    public Ash(int height, int age, int leafCount) : base(height, age)
    {
        this.leafCount = leafCount;
    }

    public override string ToString()
    {
        return $"Ash with {base.ToString()} leaf:{leafCount}";
    }
}