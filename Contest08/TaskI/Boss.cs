public class Boss : Mob
{
    public Boss(int hp, int attack) : base(hp,attack) 
    {

    }

    public override string ToString()
    {
        return $"Boss with HP = {HP} and attack = {Attack}";
    }
}
