using AntraDay4.DataModel;
using AntraDay4.Repository;

namespace AntraDay4.Presentation;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    public void Print()
    {
        List<Employee> employees = _employeeRepository.Search(employee => employee.City == "Chicago");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID : {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, City: {employee.City}, Salary: {employee.Salary}");
        }
    }
}