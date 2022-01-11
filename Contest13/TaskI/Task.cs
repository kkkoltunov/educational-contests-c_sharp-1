using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[Serializable, DataContract, KnownType(typeof(ProgramingTask)), KnownType(typeof(TextTask))]
public class Task
{
    [XmlAttribute]
    public int groupNumber;
    private int hardLvl;
    [XmlAttribute]
    public string creator;

    public Task()
    {
        
    }
    
    public int GroupNumber => groupNumber;

    [DataMember(Name = "hardLvl")]
    public int HardLvl
    {
        get => hardLvl;
        set => hardLvl = value;
    }

    public string Creator => creator;

    public static Task[] DeserializeFromXml(string xmlFile)
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Task[]), new Type[] { typeof(ProgramingTask), typeof(TextTask), typeof(Task) });

        using (FileStream fs = new FileStream(xmlFile, FileMode.Open, FileAccess.Read))
            return (Task[])formatter.Deserialize(fs);
    }

    public static void SerializeToJson(string fileName, Task[] tasks)
    {
        var stream1 = new MemoryStream();
        var ser = new DataContractJsonSerializer(typeof(Task[]));
        ser.WriteObject(stream1, tasks);
        stream1.Position = 0;
        var sr = new StreamReader(stream1);
        string dataJSON = sr.ReadToEnd();
        File.WriteAllText(fileName, dataJSON);
    }

    public static void FindAnswers(Task[] tasks)
    {
        for (int i = 0; i < tasks.Length; i++)
            AnswerGenerator.GenerateAnswer(tasks[i]);
    }
}