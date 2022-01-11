using System;
using System.Collections.Generic;
using System.IO;

public class JsonReader
{
    string dataJSON;
    double maxTemprature;

    List<House> houses = new List<House>();

    public JsonReader(string path)
    {
        string[] data = File.ReadAllLines(path);
        dataJSON = data[0];
        maxTemprature = double.Parse(data[1]);
    }

    private void ParseJSON()
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < dataJSON.Length; i++)
        {
            if (dataJSON[i] == ' ')
                continue;

            if (dataJSON[i] == '[' || dataJSON[i] == '{')
                stack.Push(dataJSON[i]);
            if (dataJSON[i] == ']' || dataJSON[i] == '}')
                stack.Pop();

            stack.TryPeek(out char ch);

            if (ch == '[' && stack.Count == 1)
            {

            }
        }
    }

    public string TheSickestStreet
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}