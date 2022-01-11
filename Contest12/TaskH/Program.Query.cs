using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    // Сортируем по возрастанию лексикографическому города и создаём на основе их группы.
    // Далее сортируем такие группы по количеству в них пользователей. Сортировка убавающая
    // Берём пять первых групп, не включая первую.
    // В каждой такой группе необходимо сгруппировать пользователей по имени, и уже каждую такую группу преобразовать в число, равное среднему возрасту этой группы.

    private static double GetAverage(IEnumerable<User> users)
    {
        var sortedGroups = users.OrderBy(x => x.City).GroupBy(x => x.City);

        var fiveGroups = sortedGroups.OrderByDescending(x => x.Count()).Skip(1).Take(5);

        var fiveGroupsSort = fiveGroups.Select(x => x.GroupBy(y => y.Name).OrderBy(z => z.Key).Select(k => k.Sum(j => j.Age)).Max());

        var finalSort = fiveGroupsSort.Distinct().Average();

        return finalSort;
    }
}