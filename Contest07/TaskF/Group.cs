using System;


public class Group
{
    Student[] students;

    public Group(Student[] students)
    {
        if (students.Length < 5)
        {
            throw new ArgumentException("Incorrect group");
        }

        this.students = students;
    }

    public int IndexOfMaxGrade()
    {
        int max = -1;
        int index = 0;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].grade > max)
            {
                max = students[i].grade;
                index = i;
            }
        }

        return index;
    }

    public int IndexOfMinGrade()
    {
        int min = 11;
        int index = 0;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].grade < min)
            {
                min = students[i].grade;
                index = i;
            }
        }

        return index;
    }

    public Student this[int index]
    {
        get
        {
            return students[index];
        }
    }
}