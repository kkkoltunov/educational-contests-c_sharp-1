using System;

public abstract partial class Product
{
    private readonly long id;

    protected Product(long id)
    {
        this.id = id;
    }

    public override string ToString() => throw new NotImplementedException();
}