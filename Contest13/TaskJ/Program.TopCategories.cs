using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<string> GetTopCategories(IEnumerable<Item> items, IEnumerable<CustomerItem> customersItems,
        IEnumerable<Customer> customers, int age, int count)
    {

        var usersList = customers.Where(customer => customer.Age >= age).Select(user => user.Id);

        var result = (from item in items
                      let countItems = customersItems.Where(customerItem => item.Id == customerItem.ItemId && usersList.Contains(customerItem.CustomerId)).Count()
                      select (item.Category, countItems));

        var sortedResult = result.OrderByDescending(x => x.countItems).ThenBy(x => x.Category).Take(count).Where(x => x.countItems != 0).Select(x => x.Category).ToList();

        return sortedResult;
    }
}