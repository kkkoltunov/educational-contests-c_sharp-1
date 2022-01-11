using System;
using System.Collections.Generic;

[Serializable]
public class Student
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public int GroupNumber { get; private set; }
    public List<int> Grades { get; private set; }

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public static Student Create(string studentInfo)
    {
        string[] dataStudent = studentInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<int> grades = new List<int>();

        for (int i = 3; i < dataStudent.Length; i++)
            grades.Add(int.Parse(dataStudent[i]));

        return new Student(dataStudent[0], dataStudent[1], int.Parse(dataStudent[2]), grades);
    }
}