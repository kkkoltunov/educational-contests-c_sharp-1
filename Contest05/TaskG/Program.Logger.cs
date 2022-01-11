using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    public static bool ParseCommandsCount(string input, out int count)
    {
        return (int.TryParse(input, out count) && count > 0);

    }

    public class Logger
    {
        List<string> logs = new List<string>();
        private static Logger logger = new Logger();

        public static Logger GetLogger()
        {
            return logger;
        }

        public static void HandleCommand(string command)
        {
            if (command.StartsWith("AddLog"))
            {
                command = command.Remove(0, 7);
                if (command[0] == '<' && command[command.Length - 1] == '>')
                {
                    command = command.Remove(0, 1).Remove(command.Length - 2, 1);
                    GetLogger().logs.Add(command);
                }
                else
                {
                    File.AppendAllText("logs.log", "Incorrect input\n");
                }
            }
            else if (command.StartsWith("DeleteLastLog"))
            {
                if (GetLogger().logs.Count != 0)
                {
                    GetLogger().logs.RemoveAt(GetLogger().logs.Count - 1);
                }
                else
                {
                    File.AppendAllText("logs.log", "No active logs\n");
                }
            }
            else if (command.StartsWith("WriteAllLogs"))
            {
                if (GetLogger().logs.Count != 0)
                {
                    File.AppendAllLines("logs.log", GetLogger().logs);
                    GetLogger().logs.Clear();
                }
                else
                {
                    File.AppendAllText("logs.log", "No active logs\n");
                }
            }
        }
    }

}