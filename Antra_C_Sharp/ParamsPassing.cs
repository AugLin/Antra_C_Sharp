namespace Antra_C_Sharp;

public class ParamsPassing
{
    public void PassingByValue(int a, int b)
    {
        a = 80;
        b = 20;
        Console.WriteLine($"Inside of the passing by values: a = {a} and b = {b}");
    }
    
    public void PassingByReference(ref int a, ref int b)
    {
        a = 80;
        b = 20;
        Console.WriteLine($"Inside of the passing by reference: a = {a} and b = {b}");
    }

    public void AreaOfCircle(double radious, double pi = 3.1415926)
    {
        Console.WriteLine($"The area of the circle is {pi * radious * radious}");
    }

    public bool IsAuthenticated(string username, string password, out string msg)
    {
        if (username == "Caifu" && password == "clin0817")
        {
            msg = "You have been verified";
            return true;
        }
        else
        {
            msg = "Invalid credentials";
            return false;
        }
    }
    
    [Obsolete(message: "Use AddNumber(param [] numbers) instead")]
    public int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }

    public int AddNumbers(params int[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        return result;
    }
}