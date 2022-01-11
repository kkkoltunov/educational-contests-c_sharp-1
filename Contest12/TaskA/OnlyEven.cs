using System;
using System.Collections;
using System.Collections.Generic;

public class OnlyEven : IEnumerable<int>
{
    private List<int> numbers;
    
    public OnlyEven(List<int> numbers)
    {
        this.numbers = numbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < numbers.Count; i++)
            if (numbers[i] % 2 == 0)
                yield return numbers[i];        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}