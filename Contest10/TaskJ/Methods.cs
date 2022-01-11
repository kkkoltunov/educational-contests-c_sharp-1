using System;
using System.Collections.Generic;
using System.Xml;

public class Methods
{
    private static XmlDocument doc;

    public static void AddChilds(XmlElement parentElement, List<string> persons)
    {
        string parentId = parentElement.GetAttribute("id");

        for (int i = 0; i < persons.Count; i++)
        {
            string[] infoAboutPerson = persons[i].Split('\t', StringSplitOptions.RemoveEmptyEntries);

            if (parentId == infoAboutPerson[1] && parentId != infoAboutPerson[0])
            {
                XmlElement xmlElement = doc.CreateElement("person");
                xmlElement.SetAttribute("id", infoAboutPerson[0]);
                xmlElement.SetAttribute("name", infoAboutPerson[3]);
                xmlElement.SetAttribute("position", infoAboutPerson[2]);
                parentElement.AppendChild(xmlElement);

                AddChilds(xmlElement, persons);
            }
        }
    }

    public static XmlDocument GetDocument(string company, List<string> persons)
    {
        XmlDocument xDoc = new XmlDocument();

        doc = xDoc;

        xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", "utf-8", null));  

        XmlElement ElementDatabase = xDoc.CreateElement("company");
        ElementDatabase.SetAttribute("name", company);
        xDoc.AppendChild(ElementDatabase);
        
        for (int i = 0; i < persons.Count; i++)
        {
            string[] data = persons[i].Split('\t', StringSplitOptions.RemoveEmptyEntries);

            if (data[0] == data[1])
            {
                XmlElement xmlElement = xDoc.CreateElement("person");
                xmlElement.SetAttribute("id", data[0]);
                xmlElement.SetAttribute("name", data[3]);
                xmlElement.SetAttribute("position", data[2]);

                ElementDatabase.AppendChild(xmlElement);

                AddChilds(xmlElement, persons);
            }
        }


        //string[] info = persons[0].Split('\t', StringSplitOptions.RemoveEmptyEntries);
        //XmlElement ElementDatabase1 = xDoc.CreateElement("person");

        //ElementDatabase1.SetAttribute("id", info[0]);
        //ElementDatabase1.SetAttribute("name", info[3]);
        //ElementDatabase1.SetAttribute("position", info[2]);
        //ElementDatabase.AppendChild(ElementDatabase1);

        //element = ElementDatabase1;

        //for (int i = 1; i < persons.Count; i++)
        //{
        //    //XmlAttribute xmlAttribute = xDoc.CreateAttribute()

        //    string[] data = persons[i].Split('\t', StringSplitOptions.RemoveEmptyEntries);
        //}

        return xDoc;
    }
}