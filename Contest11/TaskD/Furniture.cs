using System;

[Serializable]
public abstract class Furniture
{
    public long id;

    protected Furniture(long id)
    {
        this.id = id;
    }

    public Furniture() { }
}