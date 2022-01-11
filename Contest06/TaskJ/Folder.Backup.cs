using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    internal class Backup
    {
        Folder folder = new Folder();

        public Backup(Folder folder)
        {
            this.folder.files = new List<File>(folder.files);
        }   


        public static void Restore(Folder folder, Backup backup)
        {
            folder.files = new List<File>(backup.folder.files);
        }

    }

    public void AddFile(string name, int size)
    {
        files.Add(new File(name, size));
    }
    public void RemoveFile(File file)
    {
        files.Remove(file);
    }

    public File this[int i]
    {
        get 
        {
            if (i >= 0 && i < files.Count)
            {
                return files[i];
            }
            else
            {
                throw new IndexOutOfRangeException("Not enough files or index less zero");
            }
                
        }
    }

    public File this[string filename]
    {
        get 
        {
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Name == filename)
                {
                    return files[i];
                }
            }

            throw new ArgumentException("File not found");
        }
    }

    public override string ToString()
    {
        string result = $"Files in folder:";

        for (int i = 0; i < files.Count; i++)
        {
            result += "\n";
            result += files[i];
        }

        return result;
    }
}

