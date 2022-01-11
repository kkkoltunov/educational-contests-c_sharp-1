using System;

class Linguist : Editor
{
    string bannedWord;
    
    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        this.bannedWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        header = header.Replace(bannedWord, "");
        header += $" {name}";
        return header;
    }

    public static Linguist Parse(string line)
    {
        string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 3 || !int.TryParse(words[1], out int payment) || payment < 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        string bannedWord = words[2];
        string name = words[0];

        return new Linguist(name, payment, bannedWord);
    }
}