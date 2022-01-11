using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class StudentReader : IDisposable, IEnumerable<Student>
{
    List<Student> students = new List<Student>();

    public StudentReader(string path)
    {
        using (StreamReader streamReader = new StreamReader(path))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                (string, List<int>) d = Student.PreprocessStudentData(line);
                students.Add(new Student(d.Item1, d.Item2));
            }
        }
    }

    public IEnumerable<Student> GetStudentsWithGreaterGpa(double gpa)
    {
        List<Student> studentsWithGpa = new List<Student>();

        foreach (var item in students)
            if (item.Gpa > gpa)
                studentsWithGpa.Add(item);        

        return studentsWithGpa;
    }

    public IEnumerator<Student> GetEnumerator()
    {
        for (int i = 0; i < students.Count; i++)
            yield return students[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Dispose() { }
}