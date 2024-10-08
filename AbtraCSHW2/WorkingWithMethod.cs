namespace AbtraCSHW2;

public class WorkingWithMethod
{
    public int[] GenerateNumbers()
    {
        return Enumerable.Range(1, 10).ToArray();
    }

    public void ReverseNumbers(ref int[] numbers)
    {
        int start = 0;
        int end = numbers.Length - 1;

        while (start <= end)
        {
            int temp = numbers[start];
            numbers[start++] = numbers[end];
            numbers[end--] = temp;
        }
    }

    public void PrintNumbers(int[] numbers)
    {
        Console.WriteLine(string.Join(", ", numbers));
    }

    public int Fibonacci(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    
    public int Fibonacci2(int n)
    {
        if (n == 1 || n == 2) return 1;
        int [] result = new int [n + 1];
        result[0] = 1;
        result[1] = 1;
        
        for (int i = 2; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }

        return result[n-1];
    }
}