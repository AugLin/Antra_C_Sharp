using AntraDay5.DataModel;

namespace AntraDay5.Repositories;

public class EmployeeRepository
{
    private List<Employee> _employees = new List<Employee>();

    public List<Employee> GetEmployees()
    {
        return new List<Employee>(_employees)
        {
            new Employee(){Id = 1, Name = "Scott", Department = "IT", Salary = 5000, Age = 26},
            new Employee(){Id = 2, Name = "Peter", Department = "HR", Salary = 6000, Age = 30},
            new Employee(){Id = 3, Name = "Laura", Department = "IT", Salary = 7000, Age = 29},
            new Employee(){Id = 4, Name = "David", Department = "IT", Salary = 8000, Age = 27},
            new Employee(){Id = 5, Name = "Tracy", Department = "HR", Salary = 3000, Age = 25},
            new Employee(){Id = 6, Name = "Fiona", Department = "Sales", Salary = 2000, Age = 23},
            new Employee(){Id = 7, Name = "Kimin", Department = "Marketing", Salary = 4000, Age = 22}
        };
    }
}