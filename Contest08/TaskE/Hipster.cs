using System;

internal class Hipster
{
    private int money;
    private int donate;

    public Hipster(int money, int donate)
    {
        this.money = money;
        this.donate = donate;
    }

    public int GetMoney()
    {
        int temp = 0;

        if (money > donate)
        {
            temp = donate;
            money -= donate;
        }
        else
        {
            temp = money;
            money = 0;
        }

        return temp;
    }
}