using System;
using System.Collections.Generic;

public static class Methods
{
    public static int FindBestBiathlonistValue(List<Sportsman> sportsmen)
    {
        int bestScore = 0;

        for (int i = 0; i < sportsmen.Count; i++)
        {
            if (sportsmen[i] is Biathlonist)
            {
                IShooter shooter = sportsmen[i] as IShooter;
                ISkiRunner skiRunner = sportsmen[i] as ISkiRunner;

                int result = (int) (0.4 * Math.Max(shooter.Shoot(), skiRunner.Run()) + 0.6 * Math.Min(shooter.Shoot(), skiRunner.Run()));

                if (result > bestScore)
                {
                    bestScore = result;
                }
            }
        }

        return bestScore;
    }

    public static int FindBestShooterValue(List<Sportsman> sportsmen)
    {
        int bestScore = 0;

        for (int i = 0; i < sportsmen.Count; i++)
        {
            if (sportsmen[i] is Biathlonist || sportsmen[i] is Shooter)
            {
                IShooter shooter = sportsmen[i] as IShooter;

                if (shooter.Shoot() > bestScore)
                {
                    bestScore = shooter.Shoot();
                }
            }
        }

        return bestScore;
    }

    public static int FindBestRunnerValue(List<Sportsman> sportsmen)
    {
        int bestScore = 0;

        for (int i = 0; i < sportsmen.Count; i++)
        {
            if (sportsmen[i] is Biathlonist || sportsmen[i] is SkiRunner)
            {
                ISkiRunner skiRunner = sportsmen[i] as ISkiRunner;

                if (skiRunner.Run() > bestScore)
                {
                    bestScore = skiRunner.Run();
                }
            }
        }

        return bestScore;
    }
}