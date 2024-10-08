namespace AntraDay2;

public static class ExtensionMethod
{
    public static string OddOrEven(this int num)
    {
        if (num % 2 == 0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }
}