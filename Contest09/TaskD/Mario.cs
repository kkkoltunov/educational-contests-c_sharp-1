public class Mario : IHero, IPlumber, IHelper
{
    public void FixPipe(ref int numberOfCrashes)
    {
        if (numberOfCrashes > 0)
            numberOfCrashes -= 1;
    }

    public void KillMonster(ref int numberOfMonsters)
    {
        if (numberOfMonsters > 0)
            numberOfMonsters -= 1;
    }
}