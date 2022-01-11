public class Hero : IHero
{
    public void KillMonster(ref int numberOfMonsters)
    {
        if (numberOfMonsters > 0)
            numberOfMonsters -= 1;
    }
}