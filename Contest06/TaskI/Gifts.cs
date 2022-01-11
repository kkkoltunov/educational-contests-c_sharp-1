using System;

public static class GiftCreator
{
    public static Gift CreateGift(string giftName)
    {
        if (giftName == "Phone")
        {
            return new Phone();
        }
        if (giftName == "PlayStation")
        {
            return new PlayStation();
        }

        return new PlayStation();
    }
}

public class Phone : Gift
{
    static int counterPhone = 0;

    public Phone() : base(counterPhone)
    {
        counterPhone++;
    }
}

public class PlayStation : Gift
{
    static int counterPlayStation = 0;

    public PlayStation() : base(counterPlayStation)
    {
        counterPlayStation++;
    }
}

