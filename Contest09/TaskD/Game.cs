using System;
using System.Collections.Generic;

public class Game
{
    public static IList<IHelper> helpers = new List<IHelper>();
    public static int numberOfPlayedRounds = 0;
    private readonly int numberOfRounds;

    private int numberOfHeroes;
    private int numberOfPlumbers;
    private int numberOfMarios;

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        this.numberOfHeroes = numberOfHeroes;
        this.numberOfPlumbers = numberOfPlumbers;
        this.numberOfMarios = numberOfMarios;
        this.numberOfRounds = numberOfRounds;
    }

    public void Play()
    {
        string[] input;
        int countMonsters;
        int countBreaks;

        for (int i = 0; i < numberOfHeroes; i++)
        {
            helpers.Add(new Hero());
        }

        for (int i = 0; i < numberOfPlumbers; i++)
        {
            helpers.Add(new Plumber());
        }

        for (int i = 0; i < numberOfMarios; i++)
        {
            helpers.Add(new Mario());
        }

        while (numberOfRounds != numberOfPlayedRounds)
        { 
            do
            {
                input = Console.ReadLine().Split();

                if (input.Length != 2 || !int.TryParse(input[0], out countMonsters) || !int.TryParse(input[1], out countBreaks))
                {
                    Console.WriteLine("Incorrect data!");
                }
            } while (input.Length != 2 || !int.TryParse(input[0], out countMonsters) || !int.TryParse(input[1], out countBreaks));

            Round round = new Round(countMonsters, countBreaks);
            round.Play();
        }
    }
}