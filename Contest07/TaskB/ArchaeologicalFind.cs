using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    static int totalFindsNumber;

    int age;
    int weight;
    int index;
    string name;
    static int i = 0;

    public static int TotalFindsNumber
    {
        get 
        { 
            return totalFindsNumber;
        }
    }

    public ArchaeologicalFind(int age, int weight, string name)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Incorrect age");
        }
        if (weight <= 0)
        {
            throw new ArgumentException("Incorrect weight");
        }
        if (name == "?")
        {
            throw new ArgumentException("Undefined name");
        }

        this.age = age;
        this.weight = weight;
        this.name = name;
        index += i;
        i++;
    }
    
    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        totalFindsNumber += 1;

        if (!finds.Contains(archaeologicalFind))
        {
            finds.Add(archaeologicalFind);
        }
    }

    public override bool Equals(object obj)
    {
        string equal = $"{name} {age} {weight}";
        string objString = "";

        string[] o = obj.ToString().Split(" ");
        
        for (int i = 1; i < o.Length; i++)
        {
            objString += o[i];

            if (i + 1 != o.Length)
            {
                objString += " ";
            }
        }

        if (equal == objString)
        {
            return true;
        }

        return false;
    }

    public override string ToString() => $"{index} {name} {age} {weight}";
}