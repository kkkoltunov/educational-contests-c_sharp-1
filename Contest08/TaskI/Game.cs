using System;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    public AtackHeroOnPosition attackHero;

    protected int CastlePosition { get; set; }

    protected int CountOfMonsters { get; set; }

    private Hero hero;

    private Boss boss;

    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonster;
        this.hero = hero;
        this.boss = boss;
    }
    public void Play()
    {
        for (int i = 0; i <= CastlePosition; i++)
        {
            attackHero?.Invoke(hero, i);

            if (hero.HP <= 0)
            {
                Console.WriteLine("You Lose! Game over!");
                return;
            }
        }

        boss.AttackMob(hero);

        if (hero.HP <= 0)
        {
            Console.WriteLine("You Lose! Game over!");
            return;
        }

        if (hero.IsHpMoreThen75())
        {
            Console.WriteLine("You win! Princess released!");
        }
        else
        {
            Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");
        }

    }
}
