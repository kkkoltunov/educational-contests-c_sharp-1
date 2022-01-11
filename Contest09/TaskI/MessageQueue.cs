using System;
using System.Collections.Generic;

public class MessageQueue
{
    private List<Message> queue = new List<Message>();
    private int size;

    public MessageQueue(int size)
    {
        this.size = size;
    }

    public void Push(Message message)
    {
        if (queue.Count >= size)
        {
            throw new KafkaException("Queue is out of storage");
        }

        queue.Add(message);
    }

    public int Size
    {
        get { return queue.Count; }
    }

    public List<Message> this[int from, int to]
    {
        get 
        {
            List<Message> messages = new List<Message>();

            for (int i = from; i < to; i++)
            {
                messages.Add(queue[i]);
            }

            return messages;
        }
    }
}