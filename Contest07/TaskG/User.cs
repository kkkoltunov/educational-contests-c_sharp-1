using System;
using System.Collections.Generic;

public class User
{
    public string username;

    public List<string> userNotifications = new List<string>();

    public User(string username)
    {
        this.username = username;
    }

    public override string ToString() => $"-{username}-";

    public void SendMessage(string text)
    {
        if (userNotifications.Count != 0)
        {
            Console.WriteLine("Received notifications:");
            for (int i = 0; i < userNotifications.Count; i++)
            {
                Console.WriteLine(userNotifications[i]);
            }
        }

        Console.WriteLine($"New notification: {text}");
    }
    
}