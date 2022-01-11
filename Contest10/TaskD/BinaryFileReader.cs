using System;
using System.IO;

public class BinaryFileReader
{
    private string path;

    public BinaryFileReader(string path)
    {
        this.path = path;
    }

    public int GetDifference()
    {
        int inputInt32 = 0;
        int inputInt16 = 0;

        FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(fileStream);

        long count = fileStream.Length / 4;

        for (int i = 0; i < count; i++)
        {
            inputInt32 += reader.ReadInt32();
        }

        reader.BaseStream.Position = 0;

        count = fileStream.Length / 2;

        for (int i = 0; i < count; i++)
        {
            inputInt16 += reader.ReadInt16();
        }

        reader.Close();
        fileStream.Close();

        return inputInt32 - inputInt16;
    }
}