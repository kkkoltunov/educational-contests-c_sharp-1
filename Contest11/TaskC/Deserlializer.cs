using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class Deserializer
{
    public static List<Student> DeserializeStudents(string path)
    {
        List<Student> students = new List<Student>();
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
        {
            students = (List<Student>)formatter.Deserialize(fileStream);
        }

        return students;
    }
}