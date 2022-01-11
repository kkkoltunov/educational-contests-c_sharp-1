using System;
using System.Collections.Generic;

public class Server
{
    public string Name;

    public static List<string> servers = new List<string>();
    public List<string> messages = new List<string>();

    public Server()
    {
    }

    public static Server Connect(string name)
    {
        servers.Add(name);
        return new Server();
    }

    public void Send(string message)
    {
        if (servers.Count != 0)
        {
            for (int i = 0; i < servers.Count; i++)
            {
                messages.Add($"Sending data {message} to server {servers[i]}");
            }
        }
        else
        {
            throw new ArgumentException("No connected server");
        }
    }

    public void Receive(string message)
    {
        if (servers.Count != 0)
        {
            for (int i = 0; i < servers.Count; i++)
            {
                messages.Add($"Receiving data {message} from server {servers[i]}");
            }
        }
        else
        {
            throw new ArgumentException("No connected server");
        }
    }

    public void Output()
    {
        for (int i = 0; i < messages.Count; i++)
        {
            Console.WriteLine(messages[i]);
        }
    }
}