using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

public class SimpleFurnitureSerializer
{
    public void Serialize(List<Furniture> furniture, string outputPath)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Furniture>), new Type[] { typeof(Lamp), typeof(Pillow), typeof(Bed) });

        using (FileStream fileStream = new FileStream(outputPath, FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fileStream, furniture);
        }
    }
}