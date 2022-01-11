using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[Serializable]
public class Bed : Furniture
{
    [XmlElement]
    public List<Pillow> pillow;

    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        this.pillow = pillows;
    }

    public Bed() { }
}