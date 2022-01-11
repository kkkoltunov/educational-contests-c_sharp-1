using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static Dictionary<string, List<string>> Convert(KeyPredicate keyPredicate, ValuePredicate valuePredicate, Dictionary<int, List<int>> data)
    {
        Dictionary <string, List<string>> result = new Dictionary<string, List<string>>();

        foreach (var el in data.Keys)
        {
            var idList = (from id in data[el] select valuePredicate(id)).ToList();
            result.Add(keyPredicate(el), idList);
        }

        return result;
    }

    private static void LoadAreas()
    {
        using (var reader = new StreamReader(new FileStream("areas.txt", FileMode.Open)))
        {
            while (!reader.EndOfStream)
            {
                int count = 0;

                string input = reader.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] < '0' || input[i] > '9') && input[i] != ' ')
                        break;
                    else
                        count++;
                }

                string number = input.Substring(0, count);

                areas.Add(int.Parse(number), input.Substring(count));
            }
        }
    }

    private static void LoadCities()
    {
        using (var reader = new StreamReader(new FileStream("cities.txt", FileMode.Open)))
        {
            while (!reader.EndOfStream)
            {
                int count = 0;

                string input = reader.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                        break;
                    else
                        count++;
                }
                string number = input.Substring(0, count);

                cities.Add(int.Parse(number), input.Substring(++count));
            }
        }
    }
}