using System;
using System.Xml.Serialization;

[Serializable]
public class Lamp : Furniture
{
    [XmlElement(ElementName = "lifeTime")]
    public double LifeTimeSeconds;

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        LifeTimeSeconds = lifeTime.TotalSeconds;
    }

    public Lamp() { }
}