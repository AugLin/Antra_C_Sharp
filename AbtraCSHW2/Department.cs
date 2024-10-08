namespace AbtraCSHW2;

public class Department
{
    /*
     *  Department
        Will have one Instructor as head
        Will have Budget for school year (start and end Date Time)
        Will offer list of courses
     */
    public string DepartmentName { get; set; }
    public Instructor HeadInstructor { get; set; }
    public DateTime BudgetStartDate { get; set; }
    public DateTime BudgetEndDate { get; set; }
    public List<Course> CoursesOffered { get; set; }
    
    public decimal TotalBudget { get; set; }

    public Department(string name, Instructor headInstructor, DateTime budgetStartDate, DateTime budgetEndDate, decimal totalBudget)
    {
        DepartmentName = name;
        HeadInstructor = headInstructor;
        CoursesOffered = new List<Course>();
        BudgetStartDate = budgetStartDate;
        BudgetEndDate = budgetEndDate;
        TotalBudget = totalBudget;
    }

    public int TotalCourseOffered()
    {
        return CoursesOffered.Count;
    }
}