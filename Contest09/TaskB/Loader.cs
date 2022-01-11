using System;
using System.Collections.Generic;

public class Loader
{
    private static Dictionary<string, int> memory;

    public static void AddValueToStore(string key)
    {
        if (!memory.ContainsKey(key))
        {
            memory.Add(key, 1);
        }
        else
        {
            memory[key]++;
        }
    }

    public static void Download(IList<IDownload> downloadsQueue)
    {
        memory = new Dictionary<string, int>();

        for (int i = 0; i < downloadsQueue.Count; i++)
        {
            if (!downloadsQueue[i].DownloadContent())
            {
                Console.WriteLine("Not enough free space!");
                break;
            }
        }

        Console.WriteLine("\nDownloaded content:");

        // Взято с https://metanit.com/sharp/tutorial/4.9.php.
        foreach (KeyValuePair<string, int> keyValue in memory)
        {
            Console.WriteLine(keyValue.Key + ": " + keyValue.Value);
        }
    }
}