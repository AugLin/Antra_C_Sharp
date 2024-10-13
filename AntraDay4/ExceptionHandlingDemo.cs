namespace AntraDay4;

public class ExceptionHandlingDemo
{
    private int Divide(int a, int b)
    {
        return a / b;
    }

    public int Calculate(int a, int b, string operation)
    {
        if (operation == "/")
        {
            return a / b;
        }
        throw new ArgumentOutOfRangeException();
    }
}