using System;
using System.Xml.Serialization;

[Serializable, XmlInclude(typeof(Oak)), XmlInclude(typeof(Ash))]
public class Tree : IComparable
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public Tree(int height, int age)
    {
        this.height = height;
        this.age = age;
    }

    public int CompareTo(object obj)
    {
        if (height > (obj as Tree).height) 
            return 1;
        if (height < (obj as Tree).height) 
            return -1;
         
        return 0;
    }

    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }
}