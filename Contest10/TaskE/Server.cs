using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;



public class Server
{
    public static void ProcessAuthorization(string requestsPath, string requestsResultsPath)
    {
        List<string> blockedAccounts = new List<string>();
        Dictionary<string, DateTime> dictSuccess = new Dictionary<string, DateTime>();
        Dictionary<string, DateTime> dictFail = new Dictionary<string, DateTime>();

        string[] dataInput = File.ReadAllLines(requestsPath);
        string output = "";
        DateTime date;

        CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

        for (int i = 0; i < dataInput.Length; i++)
        {
            string[] current = dataInput[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (current.Length != 0)
            {
                if (UserDb.Users.ContainsKey(current[1]))
                {
                    if (!blockedAccounts.Contains(current[1]))
                    {
                        if (current[0] == "SI")
                        {
                            DateTime.TryParse(current[3] + " " + current[4], out date);

                            if (dictSuccess.ContainsKey(current[1]))
                            {
                                if ((date - dictSuccess[current[1]]) < TimeSpan.FromDays(1))
                                {
                                    blockedAccounts.Add(current[1]);
                                    output += $"{current[1]}> account blocked due suspicious login attempt\n";
                                    continue;
                                }
                                else
                                {
                                    if (UserDb.Users[current[1]] == current[2])
                                    {
                                        dictSuccess[current[1]] = date;
                                        output += $"{current[1]}> sign in successful\n";
                                    }
                                    else
                                    {
                                        if (dictFail.ContainsKey(current[1]))
                                        {
                                            if ((date - dictFail[current[1]]) < TimeSpan.FromHours(1))
                                            {
                                                blockedAccounts.Add(current[1]);
                                                output += $"{current[1]}> account blocked due suspicious login attempt\n";
                                            }
                                            else
                                            {
                                                dictFail[current[1]] = date;
                                                output += $"{current[1]}> incorrect password\n";
                                            }
                                        }
                                        else
                                        {
                                            dictFail.Add(current[1], date);
                                            output += $"{current[1]}> incorrect password\n";
                                        }

                                    }
                                }

                            }
                            else
                            {
                                if (UserDb.Users[current[1]] == current[2])
                                {
                                    dictSuccess.Add(current[1], date);
                                    output += $"{current[1]}> sign in successful\n";
                                }
                                else
                                {
                                    if (dictFail.ContainsKey(current[1]))
                                    {
                                        if ((date - dictFail[current[1]]) < TimeSpan.FromHours(1))
                                        {
                                            blockedAccounts.Add(current[1]);
                                            output += $"{current[1]}> account blocked due suspicious login attempt\n";
                                            continue;
                                        }
                                        else
                                        {
                                            dictFail[current[1]] = date;
                                            output += $"{current[1]}> incorrect password\n";
                                        }

                                    }
                                    else
                                    {
                                        dictFail.Add(current[1], date);
                                        output += $"{current[1]}> incorrect password\n";
                                    }
                                }
                            }
                        }
                        if (current[0] == "SO")
                        {
                            output += $"{current[1]}> sign out successful\n";
                            dictSuccess.Remove(current[1]);
                            dictFail.Remove(current[1]);
                        }
                    }
                    else
                    {
                        output += $"{current[1]}> account blocked due suspicious login attempt\n";
                    }
                }
                else
                {
                    output += $"{current[1]}> no user with such login\n";
                }
            }
        }

        output = output.TrimEnd('\n');

        File.WriteAllText(requestsResultsPath, output);
    }
}