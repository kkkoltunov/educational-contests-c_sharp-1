using System;
using System.Collections.Generic;

public partial class TestSystem
{
    List<User> users = new List<User>();
    List<User> usersDelete = new List<User>();

    public void Add(string username)
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].username == username)
            {
                throw new ArgumentException("User already exists");
            }
        }

        users.Add(new User(username));

        for (int i = 0; i < usersDelete.Count; i++)
        {
            if (usersDelete[i].username == username)
            {
                users[users.Count - 1].userNotifications.AddRange(usersDelete[i].userNotifications);
            }
        }
    }

    public TestSystem()
    {
        Notifications += NotificationsForUser;
    }

    public void NotificationsForUser(string message)
    {
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine(users[i]);
            users[i].SendMessage(message);
            users[i].userNotifications.Add(message);
        }
    }

    public void Remove(string username)
    {
        bool flag = false;

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].username == username)
            {
                usersDelete.Add(users[i]);
                users.RemoveAt(i);
                flag = true;
            }
        }

        if (!flag)
        {
            throw new ArgumentException("User does not exist");
        }
    }
}