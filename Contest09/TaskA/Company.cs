using System;
using System.Collections.Generic;

public class Company
{
    private readonly List<TeamLead> teamLeads;

    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        teamLeads = new List<TeamLead>();

        for (int i = 1; i <= teamLeadsAmount; i++)
        {
            List<Programmer> programmers = new List<Programmer>();

            for (int j = 1; j <= programmersAmount[i - 1]; j++)
            {
                programmers.Add(new Programmer(int.Parse($"{i}{j}")));
            }

            teamLeads.Add(new TeamLead(i, programmers));
        }
    }

    public List<TeamLead> TeamLeads
    {
        get { return teamLeads; }
    }

    public void PrintTeams()
    {
        for (int i = 0; i < teamLeads.Count; i++)
        {
            Console.WriteLine(teamLeads[i]);
            Console.WriteLine($"Written lines of code: {teamLeads[i].GetWrittenLinesOfCode() + teamLeads[i].LinesOfCode}");
        }

        Console.Write(Environment.NewLine);
    }
}