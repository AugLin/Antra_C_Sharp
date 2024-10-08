using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace AntraCSHW1;

public class Assignment2
{
    /*
     * Test your Knowledge
        1. When to use String vs. StringBuilder in C# ?
            String is an immutable object which can not be modified while StringBuilder uses
            extra memory in heap, but it is mutable.
            
        2. What is the base class for all arrays in C#?
            Array class
        
        3. How do you sort an array in C#?
            Use built-in function Array.Sort(array);
        
        4. What property of an array object can be used to get the total number of elements in
        an array?
            We can use array.Length to get the number of elements in an array
        
        5. Can you store multiple data types in System.Array?
            No, each array can have only one type.
        
        6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
            Array.CopyTo requires an pre-existing array and it copies elements into a existing array
            starting at a specified index. While Array clone will creates a new array with same size
            of the array we are trying to clone. 
        
     */
    
    /*
        Copying an Array
        Write code to create a copy of an array. First, start by creating an initial array. (You can use
        whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
        assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
        in the array.
        Now create a second array variable. Give it a new array with the same length as the first.
        Instead of using a number for this length, use the Lengthproperty to get the size of the
        original array.
        Use a loop to read values from the original array and place them in the new array. Also
        print out the contents of both arrays, to be sure everything copied correctly.
     */
    public void PracticeArray()
    {
        int[] array1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        int[] array2 = new int[10];
        array1.CopyTo(array2, 0);
        for (int i = 0; i < array2.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                Console.WriteLine($"Array1: {array1[i]}, Array2: {array2[i]}. Which is not Equal");
                return;
            }
        }
        Console.WriteLine("Array1 and Array2 is  Equal");
        
        
        /*
        Write a simple program that lets the user manage a list of elements. It can be a grocery list,
        "to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
        implement an infinite loop. Each time through the loop, ask the user to perform an
        operation, and then show the current contents of their list. The operations available should
        be Add, Remove, and Clear. The syntax should be as follows:
        + some item
        - some item
        --
        Your program should read in the user's input and determine if it begins with a “+” or “-“ or
        if it is simply “—“ . In the first two cases, your program should add or remove the string
        given ("some item" in the example). If the user enters just “—“ then the program should
        clear the current list. Your program can start each iteration through its loop with the
        following instruction:
        Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
         */
        Console.WriteLine("============================================");

        Console.WriteLine("Task 2:");
        List<string> itemList = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear, end to exit)):");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                } 
                else if (input == "--")
                {
                    itemList.Clear();
                    Console.WriteLine("List cleared.");
                }
                else if (input.StartsWith("+ "))
                {
                    string itemToAdd = input.Substring(2);
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
                else if (input.StartsWith("- "))
                {
                    string itemToRemove = input.Substring(2);
                    if (itemList.Contains(itemToRemove))
                    {
                        itemList.Remove(itemToRemove);
                        Console.WriteLine($"Removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {itemToRemove}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
                Console.WriteLine("Current List:");
                if (itemList.Count > 0)
                {
                    foreach (string item in itemList)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                }
                Console.WriteLine(); 
        }
        
        /*
         Write a method that calculates all prime numbers in given range and returns them as array
            of integers
            static int[] FindPrimesInRange(startNum, endNum)
            {
            }
         */
    }
    public int[] FindPrimesInRange(int start, int end)
    {
        List<int> list = new List<int>();

        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                list.Add(num);
            }
        }
        return list.ToArray();
    }

    public bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    /*
    4. Write a program to read an array of n integers (space separated on a single line) and an
    integer k, rotate the array right k times and sum the obtained arrays after each rotation as
    shown below.
    After r rotations the element at position I goes to position (I + r) % n.
    The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
     */
    public int[] task4(int[] array, int n)
    {
        int [] result = new int[array.Length];

        int rotation = 1;
        while (rotation <= n)
        {
            int start = 0;
            int index = rotation;
            for (int i = 0; i < array.Length - rotation; i++)
            {
                result[index++] += array[i];
            }

            for (int i = array.Length - rotation; i < array.Length; i++)
            {
                result[start++] += array[i];
            }

            rotation++;
        }
        return result;
    }
    
    /*
     5. Write a program that finds the longest sequence of equal elements in an array of integers.
        If several longest sequences exist, print the leftmost one.
     */
    public int[] task5(int[] array)
    {
        List<int> list = new List<int>();
        int maxFrequency = 0;
        for (int i = 0; i < array.Length; i++)
        {
            List<int> temp = new List<int>();
            temp.Add(array[i]);
            int start = i + 1;
            int counter = 1;
            for (; start < array.Length; start++)
            {
                if (array[start] == temp[counter-1])
                {
                    counter++;
                    temp.Add(array[start]);
                }
                else
                {
                    i = start-1;
                    break;
                }
            }
            if (counter > maxFrequency)
            {
                maxFrequency = counter;
                list = temp;
            }
        }
        return list.ToArray();
    }
    
    /*
        7. Write a program that finds the most frequent number in a given sequence of numbers. In
        case of multiple numbers with the same maximal frequency, print the leftmost of them
     */

    public int task7(int[] array)
    {
        int result = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (map.ContainsKey(array[i]))
            {
                map[array[i]]++;  // Increment the frequency if the number exists
            }
            else
            {
                map[array[i]] = 1;  // Add the number with an initial frequency of 1
            }
        }
        int maxFrequency = 0;
        foreach (int num in array)
        {
            if (map[num] > maxFrequency)
            {
                maxFrequency = map[num];
                result = num;
            }
        }
        return result;
    }
    
    /*
        Practice Strings
        1. Write a program that reads a string from the console, reverses its letters and prints the
        result back at the console.
        Write in two ways
        Convert the string to char array, reverse it, then convert it to string again
        Print the letters of the string in back direction (from the last to the first) in a for-loop
     */

    public string StringTask1(String s)
    {
        return new string(s.Reverse().ToArray());
    }
    public string StringTask1_Approach2(String s)
    {
        char[] c = s.ToCharArray();
        int start = 0;
        int end = c.Length - 1;
        while (start <= end)
        {
            char temp = c[start];
            c[start++] = c[end];
            c[end--] = temp;
        }
        return new string(c);
    }
    
    /*
        Write a program that reverses the words in a given sentence without changing the
        punctuation and spaces
        Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
        All other characters are considered part of words, e.g. C++, a+b, and a77 are
        considered valid words.
        The sentences always start by word and end by separator.
     */
    
    public string StringTask2(String s)
    {
        char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', '-' };

        List<string> parts = new List<string>();
        List<string> words = new List<string>();
        
        Regex regex = new Regex(@"([a-zA-Z0-9\+\-]+|[ .,;=:()\&\[\]""'\\/!?-]+)");
        MatchCollection matches = regex.Matches(s);
        
        foreach (Match match in matches)
        {
            parts.Add(match.Value);
            if (!Array.Exists(separators, sep => sep == match.Value[0]))
            {
                words.Add(match.Value);
            }
        }
        
        words.Reverse();
        
        int wordIndex = 0;
        for (int i = 0; i < parts.Count; i++)
        {
            if (!Array.Exists(separators, sep => sep == parts[i][0]))
            {
                parts[i] = words[wordIndex++];
            }
        }
        return string.Join("", parts);
    }
    
    public string StringTask3(String input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', '?', '!', ';', ':', '-', '_', '(', ')', '[', ']', '"' }, StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> palindromes = new HashSet<string>();
        
        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        var sortedPalindromes = palindromes.OrderBy(p => p).ToList();
        return string.Join(", ", sortedPalindromes);
    }
    public static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    
    /*
        Write a program that parses an URL given in the following format:
        [protocol]://[server]/[resource]
        The parsing extracts its parts: protocol, server and resource.
        The [server] part is mandatory.
        The [protocol] and [resource] parts are optional.
     */
    public void StringTask4(String input)
    {
        string[] words = input.Split(new char[] {'/', '.', ':'}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"[protocol] = \"{words[0]}\"");
        Console.WriteLine($"[server] = \"{words[1]}.{words[2]}.{words[3]}\"");
        if (words.Length == 5)
        {
            Console.WriteLine($"[server] = \"{words[4]}\"");
        }
        else
        {
            Console.WriteLine("[server] = \"\"");
        }
    }
}