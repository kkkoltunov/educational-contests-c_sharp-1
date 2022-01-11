using System;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

[Serializable, DataContract]
public class TextTask : Task
{
    [XmlAttribute]
    public AnswerType type;
    [XmlAttribute]
    public string question;
    private string answer;

    public TextTask()
    {
        
    }

    public AnswerType Type
    {
        get => type;
        set => type = value;
    }

    public string Question
    {
        set => question = value;
        get => question;
    }

    [DataMember(Name = "answer")]
    public string Answer
    {
        get => answer;
        set => answer = value;
    }
    
    public enum AnswerType : int
    {
        Text = 0,
        Multiple = 1,
        Single = 2
    }
}