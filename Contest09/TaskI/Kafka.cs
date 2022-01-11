using System;
using System.Collections.Generic;

public class Kafka
{
    private MessageQueue queue;
    private HashSet<User> allowed = new HashSet<User>();
    private bool isActive = false;

    public Kafka(int queueSize)
    {
        queue = new MessageQueue(queueSize);
    }

    public void Subscribe(User user)
    {
        if (allowed.Contains(user))
        {
            throw new KafkaException("User is already subscribed");
        }

        if (!isActive)
        {
            throw new KafkaException("Kafka is not active");
        }

        allowed.Add(user);
    }

    public void Unsubscribe(User user)
    {
        if (!allowed.Contains(user))
        {
            throw new KafkaException("User is already unsubscribed");
        }

        if (!isActive)
        {
            throw new KafkaException("Kafka is not active");
        }

        allowed.Remove(user);
    }

    public void Push(Message message)
    {
        if (!isActive)
        {
            throw new KafkaException("Kafka is not active");
        }

        queue.Push(message);
    }

    public List<Message> PopMessages(User user, int count)
    {
        if (queue.Size < user.Index + count)
        {
            throw new KafkaException("Not enough messages");
        }

        if (!isActive)
        {
            throw new KafkaException("Kafka is not active");
        }

        if (!allowed.Contains(user))
        {
            throw new KafkaException("User is not subscribed");
        }

        List<Message> messages = queue[user.Index, user.Index + count];

        user.IncreaseIndex(count);

        return messages;
    }

    public void Activate()
    {
        isActive = true;
    }

    public void Deactivate()
    {
        if (!isActive)
        {
            throw new KafkaException("Kafka is not active");
        }

        isActive = false;
    }
}