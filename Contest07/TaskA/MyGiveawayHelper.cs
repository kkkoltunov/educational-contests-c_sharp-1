using System;

internal class MyGiveawayHelper
{
    string[] logins;
    string[] prizes;

    int number;
    int sed = 1579;

    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        this.logins = logins;
        this.prizes = prizes;
    }

    public bool HasPrizes => prizes.Length != 0;

    public (string prize, string login) GetPrizeLogin()
    {
        number = (int)Math.Pow(sed, 2);
        sed = (number % 1000000) / 100;
        number = sed % logins.Length;

        string login = logins[number];
        string prize = prizes[0];

        for (int i = 0; i < prizes.Length - 1; i++)
        {
            prizes[i] = prizes[i + 1];
        }

        Array.Resize(ref prizes, prizes.Length - 1);

        return (prize, login);
    }
}