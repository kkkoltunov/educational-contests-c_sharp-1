using System;

public class Message
{
    private string text;
    private string dateTime;
    
    public Message(string text, string dateTime)
    {
        this.text = text;
        this.dateTime = dateTime;
    }

    public override string ToString()
    {
        return $"[{dateTime}] {text}";
    }
}