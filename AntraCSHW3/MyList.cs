namespace AntraCSHW3;

public class MyList<T>
{
    List<T> _list = new List<T>();

    public void Add(T element)
    {
        _list.Add(element);
    }

    public T Remove(int index)
    {
        T x = _list[index];
        _list.RemoveAt(index);

        return x;
    }

    public bool contains(T element)
    {
        foreach (T x in _list)
        {
            if (x.Equals(element))
            {
                return true;
            }
        }

        return false;
    }

    public void clear()
    {
        _list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        _list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        _list.RemoveAt(index);
    }

    public T Find(int index)
    {
        return _list[index];
    }
}