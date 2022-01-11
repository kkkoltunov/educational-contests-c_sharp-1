using System;
using System.Diagnostics.CodeAnalysis;

internal struct Student : IComparable<Student>
{
    private int id;
    private int height;
    private int math;
    private int english;
    private int PE;
    //private bool isMath;

    public Student(int id, int height, int math, int english, int PE)
    {
        this.id = id;
        this.height = height;
        this.math = math;
        this.english = english;
        this.PE = PE;
        //isMath = false;
    }

    internal static Student Parse(string v)
    {
        string[] input = v.Split();

        return new Student(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]));
    }

    public int CompareTo(Student other)
    {
        //if (isMath)
        //{
        //    isMath = false;
        //}
        //if (other.isMath)
        //{
        //    other.isMath = false;
        //}

        if (math > other.math)
            return 1;
        if (math < other.math)
            return -1;
        if (math == other.math)
        {
            if (english > other.english) return 1;
            if (english < other.english) return -1;
        }
        return 0;
    }

    int IComparable<Student>.CompareTo(Student other)
    {
        //if (isMath)
        //{
        //    isMath = false;
        //}
        //if (other.isMath)
        //{
        //    other.isMath = false;
        //}

        if (PE > other.PE)
            return 1;
        if (PE < other.PE)
            return -1;
        if (PE == other.PE)
        {
            if (height > other.height)
                return 1;
            if (height < other.height)
                return -1;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{id}";
    }


}