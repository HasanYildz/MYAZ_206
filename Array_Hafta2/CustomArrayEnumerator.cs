using System.Collections;

internal class CustomArrayEnumerator : IEnumerator
{

    private int index  ;
    private object[] _array;

    public CustomArrayEnumerator(object[] sourceArray)
    {
        _array = sourceArray;
        index = _array.Length;
    }

    public object Current => _array[index];
    
    
    public bool MoveNext()
    {

        if (index > 0)
        {
            index--;

            return true;
        }
        return false;
         
        
    }

    public void Reset()

    {
        index = -1;
    }
}