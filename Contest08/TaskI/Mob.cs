using System;

public abstract class Mob
{
    public int HP { get; set; }

    public int Attack { get; set; }

    public Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }
    
    public void AttackMob(Mob other)
    {
        while (true)
        {
            Console.WriteLine($"{other} attacked {this}");
            Console.WriteLine($"{this} attacked {other}");

            if (this.HP > 0)
            {
                this.HP -= other.Attack;
            }
            if (other.HP > 0)
            {
                other.HP -= this.Attack;

            }

            if (this.HP <= 0 || other.HP <= 0)
            {
                break;
            }
        }
    }
}