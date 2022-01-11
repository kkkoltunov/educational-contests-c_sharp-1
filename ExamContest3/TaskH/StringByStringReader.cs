using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class StringByStringReader
{
    private string filename;

    public StringByStringReader(string filename)
    {
        this.filename = filename;
    }

    public IEnumerator<string> GetEnumerator()
    {
        using (StreamReader sr = new StreamReader(filename))
        {
            while (!sr.EndOfStream)
            {
                yield return sr.ReadLine();
            }
        }
        yield break;
    }


    public IEnumerable<string> CutStrings(int length)
    {
        using (StreamReader sr = new StreamReader(filename))
        {
            while (!sr.EndOfStream)
            {
                string data = sr.ReadLine();

                if (data.Length > length)
                    data = data.Remove(length);

                yield return data;
            }

            yield break;
        }
    }
}