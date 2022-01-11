using System;
using System.Collections.Generic;

public class Planet<T>
{
    public int Id { get; }
    public string StarSystem { get; set; }
    public static List<Planet<T>> Planets { get; }
    public T Name { get; }
    
    private Planet(int id, T name, string starSystem)
    {
        Id = id;
        Name = name;
        StarSystem = starSystem;
    }

    static Planet()
    {
        Planets = new List<Planet<T>>();
    }

    public static void CreatePlanet(int id, T name, string starSystem)
    {
        Planets.Add(new Planet<T>(id, name, starSystem));
    }

    public override string ToString()
    {
        return $"Planet {Id}-{Name} in {StarSystem} star system";
    }
}

