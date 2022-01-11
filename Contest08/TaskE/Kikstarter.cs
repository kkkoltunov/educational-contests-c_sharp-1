using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать.
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;

    public Kikstarter(int m, Hipster[] hipsters)
    {
        if (hipsters.Length == 0)
        {
            throw new ArgumentException("Not enough hipsters");
        }

        this.m = m;

        getMoney = new GetMoneyDelegate[hipsters.Length];

        for (int i = 0; i < hipsters.Length; i++)
        {
            getMoney[i] = new GetMoneyDelegate(hipsters[i].GetMoney);
        }
    }

    public int Run()
    {
        int weeks = 0;
        int sum = 0;

        while (sum < m)
        {
            int check = 0;

            for (int i = 0; i < getMoney.Length; i++)
            {
                check += getMoney[i]();
            }

            if (check == 0)
            {
                throw new InvalidOperationException("Not enough money");
            }

            sum += check;

            weeks++;
        }

        return weeks;
    }
}