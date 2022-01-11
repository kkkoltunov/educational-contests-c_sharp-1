using System;
using System.Collections.Generic;

public static class ICollectionExtensions
{
    public static void AddRange<T>(this ICollection<int> collection, HashSet<int> hash)
    {
        foreach (var el in hash)
            collection.Add(el);
    }

    public static void AddRange<T>(this ICollection<int> collection, ICollection<int> collectionAdd)
    {
        foreach (var el in collectionAdd)
            collection.Add(el);
    }

    public static void RemoveWhere<T>(this ICollection<int> collection, Predicate<int> lambda)
    {
        var list = (List<int>)collection;
        list.RemoveAll(lambda);
    }

    public static void RemoveDuplicates<T>(this ICollection<T> collection)
    {
        List<T> list = new List<T>();

        foreach (var el in collection)
        {
            T newEl = el;
            list.Add(newEl);
        }

        collection.Clear();

        for (int i = 0; i < list.Count; i++)
            if (!collection.Contains(list[i]))
                collection.Add(list[i]);
    }

    public static ICollection<int> AllWhere<T>(this ICollection<int> collection, Predicate<int> lambda)
    {
        return ((List<int>)collection).FindAll(lambda);
    }
}