using System;

public class Converter : IConverter<MessageNetwork, MessageDb>
{
    public MessageDb Convert(MessageNetwork obj)
    {
        string content = obj.Content.Replace(" ", "");
        string url = obj.ImageNetwork.Url.Replace(" ", "");

        return new MessageDb(obj.Id, content, url);
    }
}