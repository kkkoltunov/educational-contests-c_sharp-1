using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();

    public void OutputLogs()
    {
        foreach (var el in list)
        {
            Console.WriteLine(el.Log);
        }
    }

    public void MakeLog(Print method, string line)
    {
        method(line);
    }
}

