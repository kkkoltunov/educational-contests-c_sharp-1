using System;
using System.IO;

public class Wizard : LegendaryHuman
{
    public int Rank { get; set; }

    string[] ranks = new string[]{ "Neophyte", "Adept", "Charmer", "Sorcerer", "Master", "Archmage" };
    int force;

    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints, power)
    {
        bool flag = false;

        for (int i = 0; i < ranks.Length; i++)
        {
            if (ranks[i] == rank)
            {
                Rank = i + 1;
                flag = true;
                break;
            }
        }

        if (flag == false)
        {
            throw new ArgumentException("Invalid wizard rank.");
        }

        force = power * (int)Math.Pow(Rank, 1.5) + healthPoints / 10;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        force = Power * (int)Math.Pow(Rank, 1.5) + HealthPoints / 10;

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
        return $"{ranks[Rank - 1]} Wizard {Name} with HP {HealthPoints}";
    }
}