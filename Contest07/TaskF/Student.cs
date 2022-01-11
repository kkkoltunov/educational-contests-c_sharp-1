using System;

public class Student
{
    public string name;
    public int grade;

    private Student(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }

    public static Student Parse(string line)
    {
        string name;
        string[] studentInfo = line.Split(" ");

        if (!int.TryParse(studentInfo[1], out int mark))
        {
            throw new ArgumentException("Incorrect input mark");
        }
        if (studentInfo[0].Length >= 3 && studentInfo[0][0] >= 'A' && studentInfo[0][0] <= 'Z')
        {
            name = studentInfo[0];
        }
        else
        {
            throw new ArgumentException("Incorrect name");
        }
        if (mark < 0 || mark > 10)
        {
            throw new ArgumentException("Incorrect mark");
        }

        return new Student(name, mark);
    }

    public override string ToString()
    {
        return $"{name} got a grade of {grade}.";
    }
}