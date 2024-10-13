
using AntraDay4;
using AntraDay4.Presentation;


// MathDelegate md = new MathDelegate(ArthimeticOperation.Subtract);
// // MathDelegate md = new MathDelegate(ArthimeticOperation.Add);
// Console.WriteLine(md(20, 5));


// PreDefinedDelegates pd = new PreDefinedDelegates();
// pd.ActionExample();
//
// pd.PredicateDemo();
//
// pd.FuncDemo();
//
// var person = new
// {
//     Name = "Smith",
//     Age = 30
// };

//
// ManageEmployee manageEmployee = new ManageEmployee();
// manageEmployee.Print();

try
{
    Console.WriteLine("Enter the first Number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 < 0) throw new NumberException();

    Console.WriteLine("Enter the second Number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 < 0) throw new NumberException();

    Console.WriteLine("Enter the operation");
    string operation = Console.ReadLine();

    ExceptionHandlingDemo demo = new ExceptionHandlingDemo();
// Console.WriteLine(demo.Calculate(num1, num2, operation));
    Console.WriteLine(demo.Calculate(num1, num2, operation));

}
catch (NumberException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Hello Finally Block!");
}