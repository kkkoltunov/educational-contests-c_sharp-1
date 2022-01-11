using System;
public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        s = s.Replace(initialSubstring, finalSubstring);

        replacedString = s;
    }

    public override string ToString()
    {
        return replacedString;
    }
}