using System;

public class Hero : Mob
{
    private double hpBeforeStart;

    public Hero(int hp, int attack) : base(hp, attack)
    {
        HP = hp;
        hpBeforeStart = hp;
        Attack = attack;
    }

    public bool IsHpMoreThen75()
    {
        return (HP / hpBeforeStart) >= 0.75;
    }

    public override string ToString()
    {
        return $"Mario with HP = {HP} and attack = {Attack}";
    }
}

