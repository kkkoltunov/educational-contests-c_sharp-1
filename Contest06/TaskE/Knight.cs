using System;
using System.IO;

public class Knight : LegendaryHuman
{
    string[] equipment;
    int force;

    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        if (equipment.Length == 0)
        {
            throw new ArgumentException("Not enough equipment.");
        }

        this.equipment = equipment;

        force = power + 10 * equipment.Length;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        force = Power + 10 * equipment.Length;

        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.WriteLine($"{this} attacked {enemy}.");
            enemy.HealthPoints -= force;
            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine($"{enemy} is dead.");
            }
        }
    }

    public override string ToString()
    {
        return $"Knight {Name} with HP {HealthPoints}";
    }
}