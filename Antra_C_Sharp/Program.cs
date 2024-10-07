// // See https://aka.ms/new-console-template for more information
//
// using System.Text;
// using Antra_C_Sharp;
//
// Console.WriteLine("Hello, World!");
//
// int? a = 10;
// Console.WriteLine(a);
//
// if (a.HasValue)
// {
//     Console.WriteLine(a.Value);
// }
// else
// {
//     Console.WriteLine("A does not have any value");
// }
//
// double b = 2.3123123123;
// Console.WriteLine(b);
//
// float c = 2.3123123123F;
// Console.WriteLine(c);
//
// decimal d = 2.3123123123M;
// Console.WriteLine(d);
//
// string s = "Welcome to Antra_CSharp!";
// Console.WriteLine(s);
//
// Console.WriteLine("The Value of A is : " + a);
//
// // String Interpolation (Recommended Way)
// Console.WriteLine($"The value of d is : {d}, The value of c is : {c}");
//
// string s1 = "Hello, World!";
// StringBuilder sb = new StringBuilder("hello, World!");
// sb[0] = 'H';
// Console.WriteLine(sb);
//
// //
// // int daysOfWeek = 2;
// //
// // DaysOfWeek today = DaysOfWeek.Monday;
// // Console.WriteLine(today);
//
//

using System.Net.Mail;
using Antra_C_Sharp;

ParamsPassing demo = new ParamsPassing();
int a = 100;
int b = 100;
Console.WriteLine($"Before calling passing by value method, by the value: a = {a}, b = {b}");
demo.PassingByValue(a, b);
Console.WriteLine($"After calling passing by value method, by the value: a = {a}, b = {b}");

Console.WriteLine("======================================================================================");

Console.WriteLine($"Before calling passing by value method, by the value: a = {a}, b = {b}");
demo.PassingByReference(ref a, ref b);
Console.WriteLine($"After calling passing by value method, by the value: a = {a}, b = {b}");

Console.WriteLine("======================================================================================");

demo.AreaOfCircle(radious: 10);
demo.AreaOfCircle(radious: 10, pi: 3);

Console.WriteLine("======================================================================================");

string result;
Console.WriteLine(demo.IsAuthenticated("Caifu", "clin0817",  out result));
Console.WriteLine(result);

Console.WriteLine("======================================================================================");
Console.WriteLine(demo.AddNumbers(30, 20, 10));
Console.WriteLine(demo.AddNumbers(10, 20, 10));


// Boxing
int i = 10;
object o = i;

// Unboxing
int j = (int)o;
