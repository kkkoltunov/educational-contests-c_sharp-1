using System;

public class Round
{
    private int amountOfMonsters;
    private int amountOfCrashes;

    public Round(int amountOfMonsters, int amountOfCrashes)
    {
        this.amountOfMonsters = amountOfMonsters;
        this.amountOfCrashes = amountOfCrashes;
    }

    public void Play()
    {
        var helpers = Game.helpers;

        for (int i = 0; i < Game.helpers.Count; i++)
        {
            if (helpers[i] is IHero)
            {
                IHero hero = helpers[i] as IHero;
                hero.KillMonster(ref amountOfMonsters);

            }
            if (helpers[i] is IPlumber)
            {
                IPlumber hero = helpers[i] as IPlumber;
                hero.FixPipe(ref amountOfCrashes);
            }
        }

        if (amountOfMonsters == 0 && amountOfCrashes == 0)
        {
            Console.WriteLine("Helpers won this round!");
        }
        else
        {
            if (amountOfMonsters == 0 && amountOfCrashes != 0)
            {
                Game.helpers.Add(new Plumber());
            }
            else if (amountOfMonsters != 0 && amountOfCrashes == 0)
            {
                Game.helpers.Add(new Hero());
            }
            else if (amountOfMonsters != 0 && amountOfCrashes != 0)
            {
                Game.helpers.Add(new Mario());
            }
            
            Console.WriteLine("Helpers lost this round!");
        }

        Game.numberOfPlayedRounds++;
    }
}