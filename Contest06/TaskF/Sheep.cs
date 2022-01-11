
using System;

public class Sheep
{
    public int id { get; set; }
    public string name { get; set; }
    public string sound { get; set; }

    public Sheep(int id, string name, string sound)
    {
        this.id = id;
        this.name = name;
        this.sound = sound;
    }

    public override string ToString()
    {
        return $"[{id}-{name}]: {sound}...{sound}";
    }
}
