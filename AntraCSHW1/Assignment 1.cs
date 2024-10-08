/*
 1. What type would you choose for the following “numbers”?
    a. A person’s telephone number (String)
    b. A person’s height (Double)
    b. A person’s age (Int)
    d. A person’s gender (Male, Female, Prefer Not To Answer) (Enum)
    e. A person’s salary (Decimal)
    f. A book’s ISBN (String)
    g. A book’s price (Decimal)
    h. A book’s shipping weight (Double)
    i. A country’s population (Long)
    j. The number of stars in the universe (ulong)
    k. The number of employees in each of the small or medium businesses in the 
        United Kingdom (up to about 50,000 employees per business)
        (uInt)
        
2. What are the difference between value type and reference type variables? What is
    boxing and unboxing?
    - The main difference between the value type and reference type is that the value type holds the actual value
    in the stack while the reference type holds the memory address of the value in the heap.
    - Boxing is the operation that convert a value to reference or object type and unboxing is convert object or
    Reference type to the value.
    
3. What is meant by the terms managed resource and unmanaged resource in .NET
    - Managed resource is the resource that will be managed by the garbage collector in .Net, it will free the resource
    whenever the process and reference is finish.
    - Unmanaged resource will not free the resource when the process is finished we have to use function Dispose()
    
4. Whats the purpose of Garbage Collector in .NET?
    - The purpose of garbage collector in .NET is that it will automactically allocate and release the memory
        for an application. This will reduce the complexity of programming.
 
 
 
Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal
*/

using System.Diagnostics;
using System.Text;

Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "Type", "Bytes", "Min Value", "Max Value");
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

/*
1. What happens when you divide an int variable by 0?
    Will throw a DividedByZeroException

2. What happens when you divide a double variable by 0?
    Double divided 0 will return a infinite value
    
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
    it will return a negative infinite value

4. What is the difference between x = y++; and x = ++y;?
    y++ will plus one after this line has been executed
    ++y is before this like executed, y will increment by 1

5. What is the difference between break, continue, and return when used inside a loop
statement?
    Break will terminate current loop,
    Continue will skip all remaining processes to the next loop condition.
    Return will return function and terminate all loops.
   
6. What are the three parts of a for statement and which of them are required?
    Three parts are 
    1. Initialization,
    2. Condition,
    3. Increment or decrement
    
    None of them will be required while initialization can determine outside the loop, if condition
    is empty the default will be always be true and increment or decrement can be executed inside the loop.

7. What is the difference between the = and == operators?
    = usually used to assign value or reference to a value
    while == is a comparison operation that checks the left and right side of the operator are equals.

8. Does the following statement compile? for ( ; true; ) ;
    Yes because it has the parameter of initialization, condition, and increment or decrement.
    However under this condition is better to use while loop.
    
9. What does the underscore _ represent in a switch expression?
    underscore represent the default case in a switch expression
    
10. What interface must an object implement to be enumerated over by using the foreach
statement?
    In a for each loop, an object must implement IEnumerable or IEnumerable<T>
 
Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
*/
ConvertCentury(1);
ConvertCentury(5);
void ConvertCentury(int century)
{
    int years = century * 100;
    int days = century * 36524;
    double hours = days * 24;
    ulong minutes = (ulong) hours * 60;
    ulong second = minutes * 60;
    ulong millisecond = second * 1000;
    ulong microsecond = millisecond * 1000;
    ulong nanosecond = microsecond * 1000;
    Console.WriteLine($"{century} Century = {years} = {days} days = {hours} hours = {minutes} minutes = {second} seconds" +
                      $" {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");
}

/*
    FizzBuzzis a group word game for children to teach them about division. Players take turns
    to count incrementally, replacing any number divisible by three with the word /fizz/, any
    number divisible by five with the word /buzz/, and any number divisible by both with /
    fizzbuzz/.
    Create a console application in Chapter03 named Exercise03 that outputs a simulated
    FizzBuzz game counting up to 100. The output should look something like the following
    screenshot:
 */
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(FizzBuzz(i));
}


string FizzBuzz(int input)
{
    if (input % 3 == 0 && input % 5 == 0)
    {
        return "FizzBuzz"; 
    } else if (input % 3 == 0)
    {
        return "Fizz";
    } else if (input % 5 == 0)
    {
        return "Buzz";
    }
    else
    {
        return "Invalid Input";
    }
}
/*
int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}
Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
    It will not compile because WriteLine(i) is missing class Console

What code could you add (don’t change any of the preceding code) to warn us about the
problem?
    To fix this problem we can just change the WriteLine(i) to Console.WriteLine(i);
*/

/*
Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.
*/

for (int i = 1; i <= 5; i++)
{
    int SpaceCount = 5 - i;
    int StarCount = i * 2 - 1;
    while (SpaceCount > 0)
    {
        Console.Write(" ");
        SpaceCount--;
    }

    while (StarCount > 0)
    {
        Console.Write("*");
        StarCount--;
    }
    Console.WriteLine("");

}

/*
Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
*/

int correctNumber = new Random().Next(3) + 1;
int input = 0;
Console.WriteLine($"Enter a number between 1 and 3 to guess the correct number");

while (input != correctNumber)
{
    input = int.Parse(Console.ReadLine());
    if (input == correctNumber)
    {
        Console.WriteLine($"You entered {correctNumber}. Which is correct!");
    } else if (input < 0)
    {
        Console.WriteLine("Invalid Input");
    } else if (input > 3)
    {
        Console.WriteLine("Invalid Input");
    } else if (input > correctNumber)
    {
        Console.WriteLine($"You entered {correctNumber}. Too high");
    } else if (input < correctNumber)
    {
        Console.WriteLine($"You entered {correctNumber}. Too low");
    }
}

/*
Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .
*/

DateTime birthDate = new DateTime(2000, 8, 17); 
DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int daysOld = (int)ageSpan.TotalDays;

Console.WriteLine($"You are {daysOld} days old.");

int daysToNextAnniversary = 10000 - (daysOld % 10000);
DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);

Console.WriteLine($"Your next 10,000-day anniversary will be in {daysToNextAnniversary} days.");
Console.WriteLine($"The date of your next 10,000-day anniversary is: {nextAnniversaryDate.ToShortDateString()}");


/*
Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach).
*/

DateTime time = currentDate;
int Hour = time.Hour;

string greeting = Hour switch
{
    >= 5 and < 12 => "Good Morning",
    >= 12 and < 17 => "Good Afternoon",
    >= 17 and < 21 => "Good Evening", 
    _ => "Good Night"
};

Console.WriteLine(greeting);

/*
Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.
Your output should look something like this:
0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
0,2,4,6,8,10,12,14,16,18,20,22,24
0,3,6,9,12,15,18,21,24
0,4,8,12,16,20,24
*/
Console.WriteLine("This task will read your input either 1, 2, 3, or 4 and Return you from 0 to 24");
int increment = int.Parse(Console.ReadLine());
for (int i = 0; i < 24; i += increment)
{
    Console.Write($"{i}, ");
}
Console.WriteLine($"24");

using System;
using AntraCSHW1;
Assignment2 demo = new Assignment2();
demo.PracticeArray();

int start = 10;
int end = 100;
int[] primes = demo.FindPrimesInRange(start, end);

Console.WriteLine($"Prime numbers between {start} and {end}:");
Console.WriteLine(string.Join(", ", primes));

// Task 4

int[] array = [3, 2, 4, -1];
int rotation = 2;
int [] result = demo.task4(array, rotation);

int[] array2 = [1, 2, 3, 4, 5];
int rotation2 = 3;
int [] result2 = demo.task4(array2, rotation2);

Console.WriteLine(string.Join(" ", result));
Console.WriteLine(string.Join(" ", result2));

// task 5
int[] array1 = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
int[] array2 = [1, 1, 1, 2, 3, 1, 3, 3];
int[] array3 = [4, 4, 4, 4];
int[] array4 = [0, 1, 1, 5, 2, 2, 6, 3, 3];
int [] result1 = demo.task5(array1);
int [] result2 = demo.task5(array2);
int [] result3 = demo.task5(array3);
int [] result4 = demo.task5(array4);
Console.WriteLine(string.Join(" ", result1));
Console.WriteLine(string.Join(" ", result2));
Console.WriteLine(string.Join(" ", result3));
Console.WriteLine(string.Join(" ", result4)); 

int[] array1 = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
int[] array2 = [7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10];


Console.WriteLine(demo.task7(array1));
Console.WriteLine(demo.task7(array2));
string s1 = "sample";
string s2 = "24tvcoi92";
Console.WriteLine(demo.StringTask1(s1));
Console.WriteLine(demo.StringTask1(s2));
Console.WriteLine(demo.StringTask1_Approach2(s1));
Console.WriteLine(demo.StringTask1_Approach2(s2));

string s3 = "C# is not C++, and PHP is not Delphi!";
string s4 = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
Console.WriteLine(demo.StringTask2(s3));
Console.WriteLine(demo.StringTask2(s4));

String s5 = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
Console.WriteLine(demo.StringTask3(s5));
String u1 = "https://www.google.com";
String u2 = "https://www.example.com/employee";
String u3 = "https://www.apple.com/iphone";
String u4 = "www.apple.com";
demo.StringTask4(u1);
demo.StringTask4(u2);
demo.StringTask4(u3);
demo.StringTask4(u4);