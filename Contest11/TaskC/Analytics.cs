using System;
using System.Collections.Generic;
using System.IO;

public static class Analytics
{
    public static double FindGpa(List<Student> students)
    {
        double averageAll = 0;

        for (int i = 0; i < students.Count; i++)
        {
            double average = 0;

            for (int j = 0; j < students[i].Grades.Count; j++)
            {
                average += students[i].Grades[j];
            }

            average /= students[i].Grades.Count;
            averageAll += average;
        }

        averageAll /= students.Count;
        return averageAll;
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        List<Student> studentsWithGPA = new List<Student>();

        for (int i = 0; i < students.Count; i++)
        {
            double average = 0;

            for (int j = 0; j < students[i].Grades.Count; j++)
            {
                average += students[i].Grades[j];
            }

            average /= students[i].Grades.Count;

            if (average >= gpa)
                studentsWithGPA.Add(students[i]);
        }

        List<string> dataToFile = new List<string>();

        dataToFile.Add($"{gpa:f2}");

        for (int i = 0; i < studentsWithGPA.Count; i++)
        {
            dataToFile.Add($"{studentsWithGPA[i].Name} {studentsWithGPA[i].LastName} {studentsWithGPA[i].GroupNumber}");
        }

        File.AppendAllLines(path, dataToFile);
    }
}