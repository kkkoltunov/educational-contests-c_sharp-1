using System;

public class Book : Product
{
    private readonly int age;
    long id;

    public Book(long id, int age) : base(id)
    {
        this.id = id;
        this.age = age;
    }

    public override string ToString() => $"Product. Id = {id}. Type = Book. Age = {age}";
}