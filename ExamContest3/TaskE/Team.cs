using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

public class Team : IComparable
{
    private List<IPlayer> Players { get; }

    public double Skill => Players.Sum(x => x.Skill);

    public Team(List<IPlayer> players)
    {
        Players = players;
    }

    public Team()
    {
        Players = new List<IPlayer>();
    }

    public static Team operator +(Team team, IPlayer player)
    {
        List<IPlayer> playeris;

        if (team.Players != null)
            playeris = new List<IPlayer>(team.Players);
        else
            playeris = new List<IPlayer>();

        playeris.Add(player);

        return new Team(playeris);
    }

    public static bool operator >(Team teamLeft, Team teamRight)
    {
        return teamLeft.CompareTo(teamRight) > 0;
    }

    public static bool operator <(Team teamLeft, Team teamRight)
    {
        return teamLeft.CompareTo(teamRight) < 0;
    }

    public int CompareTo(object obj)
    {
        if (obj == null)
            return 1;

        Team team = (Team)obj;

        if (team == null)
            return 1;
        else
            return Skill.CompareTo(team.Skill);
    }
}