using System;

public partial class Program
{
    private static void ChangeStarSystem(int id, string newStarSystem)
    {
        for (int i = 0; i < Planet<int>.Planets.Count; i++)
        {
            if (Planet<int>.Planets[i].Id == id)
            {
                Planet<int>.Planets[i].StarSystem = newStarSystem;
                return;
            }
        }

        for (int i = 0; i < Planet<string>.Planets.Count; i++)
        {
            if (Planet<string>.Planets[i].Id == id)
            {
                Planet<string>.Planets[i].StarSystem = newStarSystem;
                return;
            }
        }
    }
}