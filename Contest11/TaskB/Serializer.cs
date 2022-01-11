using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public static class Serializer
{
    public static List<Student> students = new List<Student>();

    public static void ReadStudents(string path)
    {
        string[] dataStudents = File.ReadAllLines(path);

        for (int i = 0; i < dataStudents.Length; i++)
            students.Add(Student.Create(dataStudents[i]));        
    }

    public static void SerializeStudents(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
        {
            formatter.Serialize(fileStream, students);
        }
    }
}