using System.IO;

public static partial class Program
{
    private static int GetCountCapitalLetters(string inputPath)
    {
        string text = File.ReadAllText(inputPath);

        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= 'A' && text[i] <= 'Z')
            {
                count++;
            }
        }

        return count;
    }

    private static void WriteCount(string outputPath, int count)
    {
        string countStr = count.ToString();
        File.WriteAllText(outputPath, countStr);
        System.Console.WriteLine(countStr);
    }
}