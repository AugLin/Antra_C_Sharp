namespace AbtraCSHW2;


/*
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



 */

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollCourse(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    Department Department { get; set; }
    bool IsHeadOfDepartment();
}
