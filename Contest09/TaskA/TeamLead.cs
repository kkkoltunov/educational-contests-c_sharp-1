using System;
using System.Collections.Generic;

public class TeamLead : Programmer
{
    private readonly List<Programmer> programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        this.programmers = programmers;
    }

    public List<Programmer> Programmers
    {
        get { return programmers; }
    }

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        for (int i = 0; i < teamLeads.Count; i++)
        {
            List<Programmer> programmers = teamLeads[i].Programmers;

            for (int j = 0; j < programmers.Count; j++)
            {
                if (programmers[j].LinesOfCode % (Id + 1) == 0)
                {
                    this.programmers.Add(programmers[j]);
                    programmers.Remove(programmers[j]);
                }
            }

        }
    }

    public int GetWrittenLinesOfCode()
    {
        int sum = 0;

        for (int i = 0; i < programmers.Count; i++)
        {
            sum += programmers[i].LinesOfCode;
        }

        return sum;
    }

    public override string ToString()
    {
        return String.Format("Team lead #{0}\nAmount of programmers in team: {1}", Id, programmers.Count);
    }
}