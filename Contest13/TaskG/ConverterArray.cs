using System;
using System.Collections;

public class ConverterArray<TV, TU> : IEnumerable
{
    private readonly TV[] originArr;
    private readonly TU[] notOriginArr;
    private readonly IConverter<TV, TU> converter;

    public ConverterArray(int length, IConverter<TV, TU> converter)
    {
        originArr = new TV[length];
        notOriginArr = new TU[length];
        this.converter = converter;
    }

    public TU GetAt(int index)
    {
        notOriginArr[index] = converter.Convert(originArr[index]);
        return converter.Convert(originArr[index]);        
    }

    public IEnumerator GetEnumerator()
    {
        return notOriginArr.GetEnumerator();
    }

    public void SetAt(int index, TV element)
    {
        originArr[index] = element;
    }
}