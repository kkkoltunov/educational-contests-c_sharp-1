using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    Dictionary<string, Permissions> database = new Dictionary<string, Permissions>();

    public void CreateFile(string filename)
    {
        database.Add(filename, Permissions.Default);
    }

    public void AddPermission(string filename, string permissionName)
    {
        database[filename] |= PermissionBuilder.FromName(permissionName);
    }

    public void RemovePermission(string filename, string permissionName)
    {
        database[filename] &= ~PermissionBuilder.FromName(permissionName);
    }

    public override string ToString()
    {
        string result = String.Empty;

        int count = database.Count;
        int i = 1;

        foreach (KeyValuePair<string, Permissions> keyValue in database)
        {
            result += $"{keyValue.Key}: {keyValue.Value}";
            i++;
            if (i <= count)
            {
                result += $"\n";
            }
        }

        result = result.Replace(",", "");

        return result;
    }
}