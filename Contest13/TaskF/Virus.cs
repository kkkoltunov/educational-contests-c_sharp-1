using System;

public class Virus : IComparable<Virus>
{
    private int infectedCount;
    private double dangerIndex;
    private int typeNumber;

    public Virus(int infectedCount, double dangerIndex, int typeNumber)
    {
        this.infectedCount = infectedCount;
        this.dangerIndex = dangerIndex;
        this.typeNumber = typeNumber;
    }

    public static Virus GetSum(Virus[] arr, int firstN)
    {
        if (firstN <= 0 || firstN > arr.Length)
            throw new ArgumentException("Incorrect value");

        if (firstN == 1)
            return arr[0];

        Virus virus = arr[0];

        for (int i = 1; i < firstN; i++)
            virus += arr[i];

        return virus;
    }
    
    public static Virus GetDifference(Virus[] arr, int lastN)
    {
        if (lastN <= 0 || lastN > arr.Length)
            throw new ArgumentException("Incorrect value");

        if (lastN == 1)
            return arr[arr.Length - 1];

        Virus virus = arr[arr.Length - 1];

        for (int i = arr.Length - 2; i >= arr.Length - lastN; i--)
            virus -= arr[i];
        return virus;
    }

    public override string ToString()
    {
        return $"{infectedCount} {dangerIndex:F2} {typeNumber}";
    }

    public static Virus operator +(Virus virusFirst, Virus virusSecond)
    {
        var newInfectedCount = virusFirst.infectedCount + virusSecond.infectedCount;
        var newDangerIndex = virusFirst.typeNumber & virusSecond.typeNumber;
        var newTypeNumber = virusFirst.typeNumber | virusSecond.typeNumber;

        Virus virus = new Virus(newInfectedCount, (1.0 * newInfectedCount) / newDangerIndex, newTypeNumber);

        return virus;
    }

    public static Virus operator -(Virus virusFirst, Virus virusSecond)
    {
        var newInfectedCount = Math.Abs(virusFirst.infectedCount - virusSecond.infectedCount);
        var newTypeNumber = virusFirst.typeNumber & virusSecond.typeNumber;
        var newDangerIndex = (1.0 * newInfectedCount) / newTypeNumber;

        Virus virus = new Virus(newInfectedCount, newDangerIndex, newTypeNumber);

        return virus;
    }

    public int CompareTo(Virus virus)
    {
        if (dangerIndex > virus.dangerIndex)
            return 1;
        else if (dangerIndex < virus.dangerIndex)
            return -1;
        else
        {
            if (infectedCount > virus.infectedCount)
                return 1;
            else if (infectedCount < virus.infectedCount)
                return -1;
            else
            {
                if (typeNumber > virus.typeNumber)
                    return 1;
                if (typeNumber < virus.typeNumber)
                    return -1;
            }
        }

        return 0;
    }
}