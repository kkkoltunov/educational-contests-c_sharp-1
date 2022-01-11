using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class ReadWriter
{
    public static Tuple<char, char> GetMostAndLeastCommonLetters(string path)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        bool flag = false;

        string[] data = File.ReadAllLines(path, Encoding.UTF8);

        for (int i = 0; i < data.Length; i++)
        {
            string[] current = data[i].ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < current.Length; j++)
            {
                for (int z = 0; z < current[j].Length; z++)
                {
                    if (current[j][z] >= 'a' && current[j][z] <= 'z')
                    {
                        flag = true;

                        if (!dict.ContainsKey(current[j][z]))
                        {
                            dict.Add(current[j][z], 1);
                        }
                        else
                        {
                            dict[current[j][z]]++;
                        }
                    }
                }
            }
        }

        if (flag)
        {
            var max = dict.Values.Max();
            var min = dict.Values.Min();

            char maxChar = dict.Where(x => x.Value == max).FirstOrDefault().Key;
            char minChar = dict.Where(x => x.Value == min).FirstOrDefault().Key;

            return Tuple.Create(minChar, maxChar);
        }
        else
        {
            return Tuple.Create(' ', ' ');
        }
    }

    public static void ReplaceMostRareLetter(Tuple<char, char> leastAndMostCommon, string inputPath, string outputPath)
    {
        string[] dataInput = File.ReadAllLines(inputPath, Encoding.UTF8);

        for (int i = 0; i < dataInput.Length; i++)
        {
            dataInput[i] = dataInput[i].Replace(leastAndMostCommon.Item1, leastAndMostCommon.Item2);
            dataInput[i] = dataInput[i].Replace((char)(leastAndMostCommon.Item1 - 32), (char)(leastAndMostCommon.Item2 - 32));
        }

        File.WriteAllLines(outputPath, dataInput);
    }
}