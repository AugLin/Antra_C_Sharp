using System.Text;

namespace AntraDay4;

public class PreDefinedDelegates
{
    // Fibonacci Sequence

    private void Fibonacci(int n)
    {
        int a = 0, b = 1, c = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a + " ");

            c = a + b;
            b = a;
            a = c;
        }
    }

    public void ActionExample()
    {
        // Action<int> fib = new Action<int>(Fibonacci);
        // fib(10);

        // Another Way
        // Action<int> fib = delegate(int length)
        // {
        //     int a = 0, b = 1, c = 0;
        //
        //     for (int i = 0; i < length; i++)
        //     {
        //         Console.WriteLine(a + " ");
        //
        //         c = a + b;
        //         b = a;
        //         a = c;
        //     }
        // };
        // fib(10);

        // Another way

        Action<int> fib = n =>
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                b = a;
                a = c;
            }
        };

        fib(10);
    }

    public void PredicateDemo()
    {
        //

        Predicate<string> palidrome = str =>
        {
            int right = str.Length - 1;
            int left = 0;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        };
        Console.WriteLine(palidrome("abaeba"));
    }

    public void FuncDemo()
    {
        // Factorial

        Func<int, string> factorial = num =>
        {
            int f = 1;
            for (int i = num; i >= 1; i--)
            {
                f = f * i;
            }
            return f.ToString();
        };
        Console.WriteLine(factorial(5));
    }

}