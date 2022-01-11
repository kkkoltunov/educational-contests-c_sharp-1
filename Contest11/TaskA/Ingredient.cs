using System;
using System.Runtime.Serialization;

[DataContract, KnownType(typeof(Meat)), KnownType(typeof(Vegetable))]
public class Ingredient : IComparable
{
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    protected int TimeToCook { get; set; }

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }

    public int CompareTo(object obj)
    {
        if (TimeToCook > (obj as Ingredient).TimeToCook) return -1;
        if (TimeToCook < (obj as Ingredient).TimeToCook) return 1;
        else return 0;
    }

    public override string ToString()
    {
        return Name;
    }
}