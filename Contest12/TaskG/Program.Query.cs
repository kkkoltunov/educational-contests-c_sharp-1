using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    // Необходимо:
    // 1. Сформировать группы юзеров по их имени, предварительно отсортировав их по возрасту в убывающем порядке (от большего к меньшему).
    // 2. Отфильтровать группы: оставить в группах только тех пользователей, чей возраст строго больше 10.
    // 3. Из каждой группы взять m пользователей, предварительно отсортировав по Id, и вывести на экран сумму возрастов таких пользователей.
    private static IEnumerable<IGrouping<string, User>> GetGroups(List<User> users)
    {

        return users.OrderByDescending(x => x.Age).GroupBy(y => y.Name);
    }

    private static List<int> GetQueryResult(IEnumerable<IGrouping<string, User>> groups, int m)
    {
        //foreach (var otherGroup in groups)
        //    foreach (var el in otherGroup)
        //    {
        //        Console.WriteLine(el.Id);
        //    }

        //var newSort = from oneGroup in groups
        //              from one in oneGroup
        //              group one by one.Id;

        var sortAge = groups.Select(g => g.Where(x => x.Age > 10));

        var finalSort = sortAge.Select(g => g.OrderBy(x => x.Id).Take(m).Sum(y => y.Age));

        return finalSort.ToList();
    }
}