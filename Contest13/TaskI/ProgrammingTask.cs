using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[Serializable, DataContract]
public class ProgramingTask : Task
{
    [XmlAttribute]
    public string language;
    [XmlAttribute]
    public int maxLinesOfCode;
    private string answer;
    
    public ProgramingTask()
    {
        
    }

    public string Language
    {
        get { return language; }
        set { language = value; }
    }

    public int MaxLinesOfCode
    {
        get { return maxLinesOfCode; }
        set { maxLinesOfCode = value; }
    }

    [DataMember(Name = "answer")]
    public string Answer
    {
        get => answer;
        set => answer = value;
    }
}