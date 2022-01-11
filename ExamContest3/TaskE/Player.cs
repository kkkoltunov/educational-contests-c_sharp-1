using System;

public class Player : IPlayer
{
    private readonly string name;
    private readonly int age;
    private readonly int speed;
    private readonly int shooting;

    private Player(string name, int age, int speed, int shooting)
    {
        this.name = name;
        this.age = age;
        this.speed = speed;
        this.shooting = shooting;
    }

    public double Skill => speed * 1.5 + shooting * 2 - 0.5 * (age - 30.0);

    public static Player Parse(string str)
    {
        int shooting;

        var data = str.Split(";");

        if (data[0] == "" || data[0] == null || string.IsNullOrWhiteSpace(data[0]))
            throw new ArgumentException("Incorrect input");
        
        if (!int.TryParse(data[1], out int age) || !int.TryParse(data[2], out int speed) || !int.TryParse(data[3], out shooting))
            throw new ArgumentException("Incorrect input");

        return new Player(data[0], age, speed, shooting);
    }
}