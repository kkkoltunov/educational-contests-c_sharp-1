using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("input.txt");

        ushort[] dataUShort = new ushort[data.Length];

        for (int i = 0; i < dataUShort.Length; i++)
        {
            ushort.TryParse(data[i], out dataUShort[i]);
        }

        using (BinaryWriter writer = new BinaryWriter(File.Open("output.bin", FileMode.OpenOrCreate)))
        {
            foreach (var el in dataUShort)
            {
                writer.Write(el);
            }
        }
    }
}