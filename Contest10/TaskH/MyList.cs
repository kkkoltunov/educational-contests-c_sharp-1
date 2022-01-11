using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class MyList<T>
{
    private T[] array;

    private int countElements;

    public MyList()
    {
        array = new T[0];
    }

    public MyList(int capacity)
    {
        array = new T[capacity];
    }

    public int Count => countElements;

    public int Capacity => array.Length;


    public void Add(T element)
    {
        if (array.Length == 0)
            Array.Resize(ref array, 4);
        else
            if (countElements == array.Length)
                Array.Resize(ref array, array.Length * 2);
        
        array[countElements++] = element;
    }

    public T this[int x]
    {
        get
        {
            if (x >= 0 && x < countElements)
                return array[x];
            else
                throw new IndexOutOfRangeException();
        }
    }

    public void Clear()
    {
        array = new T[array.Length];
        countElements = 0;
    }

    public void RemoveLast()
    {
        T[] arrayUseless = new T[1];
        array[--countElements] = arrayUseless[0];
    }

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < countElements)
        {
            Array.Clear(array, index, 1);

            for (int i = index; i < array.Length - 1; i++)
                array[i] = array[i + 1];

            countElements--;
        }
        else
            throw new IndexOutOfRangeException();
    }

    public T Max()
    {
        if (countElements == 0)
            throw new IndexOutOfRangeException();

        if (array[0] is IComparable)
        {
            T[] arrayUseless = new T[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                T element = array[i];
                arrayUseless[i] = element;
            }

            Array.Sort(arrayUseless);

            return arrayUseless[array.Length - 1];
        }
        else
            throw new NotSupportedException("This operation is not supported for this type");
    }

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < countElements; i++)
        {
            result += $"{array[i]} ";
        }

        return result;
    }
}