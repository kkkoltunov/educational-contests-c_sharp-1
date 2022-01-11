using System;

public abstract partial class Product
{
    public static Product Parse(string line)
    {
        string[] input = line.Split(';', StringSplitOptions.RemoveEmptyEntries);

        if (input[0] == "Book")
            return new Book(long.Parse(input[1]), int.Parse(input[2]));
        if (input[0] == "Notebook")
            return new Notebook(long.Parse(input[1]), input[2]);

        throw new ArgumentException("Incorrect type");
    }
}