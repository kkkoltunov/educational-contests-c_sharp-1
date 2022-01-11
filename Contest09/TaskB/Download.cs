using System;

public class Download<T> : IDownload where T : Content
{
    private readonly T download;

    public Download(T download)
    {
        this.download = download;
    }

    public bool DownloadContent()
    {
        if (download.Size != 0)
        {
            if (Program.FreeSpace - download.Size >= 0)
            {
                Loader.AddValueToStore(download.GetType().ToString());
                Console.WriteLine($"{download.Size}/{download.Size} MB");
                Program.FreeSpace -= download.Size;
                return true;
            }
            else
            {
                if (Program.FreeSpace > 0)
                    Console.WriteLine($"{Program.FreeSpace}/{download.Size} MB");
                return false;
            }
        }
        else
        {
            Loader.AddValueToStore(download.GetType().ToString());
            return true;
        }
    }
}