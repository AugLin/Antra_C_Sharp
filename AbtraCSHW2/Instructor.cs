using System.Runtime.CompilerServices;

namespace AbtraCSHW2;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime StartDate { get; set; }

    public bool IsHeadOfDepartment()
    {
        if (Department.HeadInstructor == this)
        {
            return true;
        }
        return false;
    }

    public decimal CalculateSalary()
    {
        int YOE = DateTime.Today.Year - StartDate.Year;
        return base.CalculateSalary() + 1000 * YOE;
    }
}