using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hipster
{
    int departureDay;
    int arrivalDay;

    public int PostsRead { get; private set; }

    public Hipster(int departureDay, int arrivalDay)
    {
        this.departureDay = departureDay;
        this.arrivalDay = arrivalDay;
    }

    public void ReadPost(DateTime date)
    {
        for (int i = departureDay; i <= arrivalDay; i++)
        {
            if (date.Day == i)
            {
                return;
            }
        }

        PostsRead++;
    }

    public void Subscribe(Blogger blogger)
    {
        blogger.Post += ReadPost;
    }
}

