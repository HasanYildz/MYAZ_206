using System.Collections;
using System;

public class Array1 : IEnumerable,ICloneable
{
    private Object[] innerList { get; set; }
    public int Length => innerList.Length;
    public Array1(int defalutSize = 16)
    {
        innerList = new object[defalutSize];
    }
    public Array1(params Object[] sourceArray) : this(sourceArray.Length)
    {
        Array.Copy(sourceArray, innerList, sourceArray.Length);
    }
    public Object GetValue(int index)
    {
        if (!(index >= 0 && index <= innerList.Length))
        {

            throw new ArgumentOutOfRangeException();
        }
        return innerList[index];
    }
    public void SetValue(Object value , int index)
    {
        if (!(index >= 0 && index <= innerList.Length))
        {
           throw  new ArgumentOutOfRangeException();
        }
        if (value is null)
        {
            throw new ArgumentNullException();
        }
        innerList[index] = value;
    }

    public IEnumerator GetEnumerator()
    {

        return new CustomArrayEnumerator(innerList);
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}