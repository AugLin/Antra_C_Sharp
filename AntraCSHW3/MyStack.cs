namespace AntraCSHW3;

public class MyStack <T>
{
    Stack<T> _stack = new Stack<T>();

    public int Count()
    {
        return _stack.Count;
    }

    public T Pop()
    {
        return _stack.Pop();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }
}