/*
1. What are the six combinations of access modifier keywords and what do they do? 
    public - Most open modifier that allows access from anywhere
    
    private - Only allows access with in the same class, or my the method provided in the class
    
    protected - Use when we want allow subclass to access the a member but prevent access from any 
                access from any outside the class
                
    private protected - More restrictive combination that limits the access to derived class but only
                        of theyu are same assembly as the base class.

    internal - Limiting the access to member within the same program but not exposing them to external.
    
    protected internal - Combination that allows access to subclass and any code within the same assembly
                        offering mix of protected and internal.
    
2.What is the difference between the static, const, and readonly keywords when applied to a type member?
    Static - static applies to a member of a class that is shared across all instances and belongs to the class
            itself rather to any instance.
    const - Compile time constance that can not be changed afterward.
    readOnly - members initiated at the declaration and restrict the activities on this member can be only be
                read and does not allow any modifications

3. What does a constructor do?
    - Constructor that allows external class to create an instance of the current class.
    - A class will have default constructor


4. Why is the partial keyword useful?
    - Partial allows the inheritance of a class to have sub-classes. Which improves the code reusability

5. What is a tuple?
    - Tuple is a group of same or different value to a variable.
    
6. What does the C# record keyword do?
    - Record is used to define immutable reference type that is primarily intended to model data rather than
        behavior.
        
7. What does overloading and overriding mean?
    - Overloading is the same function in the same class that have same access modifier, same name but
        different input parameter and output.
    - Overriding is the derived class use same method signatures including access modifier, name, input and output parameters.

8. What is the difference between a field and a property?
    - field and property both defines a variable in a class while property will have the logic of setter and getter.

9. How do you make a method parameter optional?
    - If we assign a value to the parameter, it will be optional,
    example, public int addValue(int a, int b = 2)
    in this case if we provide value for a and b, the parameter will become a and b. if we only provide value for a,
    the value of b will be default which is 2.

10. What is an interface and how is it different from abstract class?
    An interface defines a contract with only method and property signatures (no implementation), while an abstract
    class can include both abstract methods (without implementation) and concrete methods (with implementation)
    
11. What accessibility level are members of an interface?
    All members of an interface are implicitly public, that means there will not be any private or protected.

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
    True

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
    True

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
    false

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
    False

16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
    True

17. True/False. Derived classes can override methods that were virtual in the base class. 
    True

18. True/False. Derived classes can override methods that were abstract in the base class. 
    False

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.
    False


20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
    False

21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
    True

22. True/False. A class can have more than one base class.
    False
    
23. True/False. A class can implement more than one interface.
    True
*/

/*
Working with methods
1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
Your Mainmethod will look something like this:
static void Main(string[] args) {
int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);
}
The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
change the method to allow the desired length to be passed in, instead of just always
being 10.)
The PrintNumbersmethod should use a foror foreachloop to print out each item in the
array. The Reversemethod will be the hardest. Give it a try and see what you can make
happen. If you get
stuck, here’s a couple of hints:
Hint #1:To swap two values, you will need to place the value of one variable in a temporary
location to make the swap:
// Swapping a and b.
int a = 3;
int b = 5;
int temp = a;
a = b;
b = temp;
Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
and going up to the length of the array / 2. The number you use in the forloop will be the
index of the first number to swap, and the other one will be the length of the array minus
the index minus 1. This is to account for the fact that the array is 0-based. So basically,
you’ll be swapping array[index]with array[arrayLength – index – 1].
*/

using System.Globalization;
using AbtraCSHW2;

WorkingWithMethod task1 = new WorkingWithMethod();
int[] array = task1.GenerateNumbers();
task1.ReverseNumbers(ref array);
task1.PrintNumbers(array);


/*
The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5. This keeps going forever.
The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
Because one number is defined by the numbers before it, this sets up a perfect
opportunity for using recursion.
Your mission, should you choose to accept it, is to create a method called Fibonacci, which
takes in a number and returns that number of the Fibonacci sequence. So if someone calls
Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
someone calls Fibonacci(8), it would return 21.
In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
sequence and print them out.
Hint #1:Start with your base case. We know that if it is the 1st or 2nd number, the value will
be 1.
Hint #2:For every other item, how is it defined in terms of the numbers before it? Can you
come up with an equation or formula that calls the Fibonaccimethod again?
*/
WorkingWithMethod task2 = new WorkingWithMethod();
Console.WriteLine(task2.Fibonacci(8));
Console.WriteLine(task2.Fibonacci2(8));

/*
Designing and Building Classes using object-oriented principles
1. Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism/.
2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.
3. Use /Encapsulation/ to keep many details private in each class.
4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.
5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.
6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
person specific methods). IStudentService, IInstructorService should inherit from
IPersonService.
Person
Calculate Age of the Person
Calculate the Salary of the person, Use decimal for salary
Salary cannot be negative number
Can have multiple Addresses, should have method to get addresses
Instructor
Belongs to one Department and he can be Head of the Department
Instructor will have added bonus salary based on his experience, calculate his
years of experience based on Join Date
Student
Can take multiple courses
Calculate student GPA based on grades for courses
Each course will have grade from A to F
Course
Will have list of enrolled students
Department
Will have one Instructor as head
Will have Budget for school year (start and end Date Time)
Will offer list of courses
 */
Instructor instructor1 = new Instructor
{
    Name = "Hassan Ibrahim",
    Birthday = new DateTime(1980, 1, 1),
    StartDate = new DateTime(2010, 1, 1),
    Salary = 80000
};
instructor1.AddAddress("123 Main St");

Instructor instructor2 = new Instructor
{
    Name = "John Bono",
    Birthday = new DateTime(1959, 12, 11),
    StartDate = new DateTime(1999, 12, 12),
    Salary = 60000
};
instructor2.AddAddress("321 Main St");

DateTime startDate = new DateTime(2024, 1, 1);
DateTime endDate = new DateTime(2025, 1, 1);

Department department = new Department("Computer Science", instructor1, startDate, endDate, 10000000);
instructor1.Department = department;
instructor2.Department = department;

Course course1 = new Course { CourseName = "C# Programming" };
Course course2 = new Course { CourseName = "SQL" };
department.CoursesOffered.Add(course1);
department.CoursesOffered.Add(course2);

Student student1 = new Student
{
    Name = "Alice",
    Birthday = new DateTime(2000, 6, 15),
    Salary = 0
};
Student student2 = new Student
{
    Name = "John",
    Birthday = new DateTime(1999, 6, 22),
    Salary = 0
};
Student student3 = new Student
{
    Name = "Frank",
    Birthday = new DateTime(2001, 3, 15),
    Salary = 0
};
Student student4 = new Student
{
    Name = "Zoe",
    Birthday = new DateTime(2002, 1, 13),
    Salary = 0
};
student1.AddAddress("456 Oak St");

student1.EnrollCourse(course1);
student1.SetGrade(course1, "A");
student1.SetGrade(course2, "B");

student2.SetGrade(course1, "A");
student2.EnrollCourse(course1);
student3.SetGrade(course1, "A");
student3.EnrollCourse(course1);
student4.SetGrade(course1, "A");
student4.EnrollCourse(course1);


Console.WriteLine($"{student1.Name}'s GPA: {student1.CalculateGPA()}");
Console.WriteLine($"{instructor1.Name}'s Salary: {instructor1.CalculateSalary()}");
Console.WriteLine($"{instructor1.Name} is head of the {instructor1.Department.DepartmentName} department: {instructor1.IsHeadOfDepartment()}");
Console.WriteLine($"{instructor2.Name}'s Salary: {instructor2.CalculateSalary()}");
Console.WriteLine($"{instructor2.Name} is head of the {instructor2.Department.DepartmentName} department: {instructor2.IsHeadOfDepartment()}");
Console.WriteLine($"Department Name is : {department.DepartmentName}. In Term {department.BudgetStartDate} to {department.BudgetEndDate} with Total of ${department.TotalBudget}");
Console.WriteLine($"Department of {department.DepartmentName} total offering {department.TotalCourseOffered()} courses");
Console.WriteLine($"Course {course1.CourseName} total serving {course1.GetStudents()} students");