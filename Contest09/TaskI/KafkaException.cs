using System;

public class KafkaException : Exception
{
    public KafkaException(string text) : base(text) { }
}