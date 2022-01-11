using System;

public static partial class Program
{
    public static void Main()
    {
        const string inputFilePath = "rick.in.txt";
        const string outputFilePath = "morty.out.txt";
        WriteCount(outputFilePath, GetCountCapitalLetters(inputFilePath));
    }
}