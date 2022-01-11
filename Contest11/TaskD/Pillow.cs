using System;
using System.Xml.Serialization;

[Serializable]
public class Pillow
{
    public long id;

    public string isRuined;

    public Pillow(long id, bool isRuined)
    {
        this.id = id;

        if (isRuined)
            this.isRuined = "Yes";
        else
            this.isRuined = "No";
    }

    public Pillow() { }
}