using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class RandomProxy
{
    StreamWriter log;
    Dictionary<string, int> users = new Dictionary<string, int>();
    Random random = new Random(1579);

    public RandomProxy(StreamWriter log)
    {
        this.log = log;
    }

    public void Register(string login, int age)
    {
        if (users.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is already registered");
        }
        else
        {
            log.WriteLine($"User {login}: login registered");
            users.Add(login, age);
        }
    }

    public int Next(string login)
    {
        int randomNum = 0;

        if (!users.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }

        if (users[login] < 20)
        {
            randomNum = random.Next(0, 1000);
        }
        else
        {
            randomNum = random.Next(0, int.MaxValue);
        }

        log.WriteLine($"User {login}: generate number {randomNum}");

        return randomNum;
    }

    public int Next(string login, int maxValue)
    {
        int randomNum = 0;

        if (!users.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }

        if (maxValue > 1000 && users[login] < 20)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }

        randomNum = random.Next(0, maxValue);

        log.WriteLine($"User {login}: generate number {randomNum}");

        return randomNum;
    }

    public int Next(string login, int minValue, int maxValue)
    {
        int randomNum = 0;

        if (!users.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }

        if (maxValue > 1000 && users[login] < 20)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }

        randomNum = random.Next(minValue, maxValue);

        log.WriteLine($"User {login}: generate number {randomNum}");

        return randomNum;
    }

}
