using System;

public class User
{
    private long id;
    private string name;
    private ushort age;

    public long Id
    {
        get => id;
        private set
        {
            id = value;
        }
    }
    
    public string Name
    {
        get => name;
        private set
        {
            name = value;
        }
    }
    
    public ushort Age
    {
        get => age;
        private set
        {
            age = value;
        }
    }

    private User(long id, string name, ushort age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public static User Parse(string str)
    {
        string[] data = str.Split(';');

        if (!long.TryParse(data[0], out long id) || !ushort.TryParse(data[2], out ushort age))
            throw new ArgumentException("Incorrect input");

        if (id <= 0)
            throw new ArgumentException("Incorrect input");

        if (age > 128)
            throw new ArgumentException("Incorrect input");

        for (int i = 0; i < data[1].Length; i++)
            if (data[1][i] >= '0' && data[1][i] <= '9')
                throw new ArgumentException("Incorrect input");


        return new User(id, data[1], age);
    }
}