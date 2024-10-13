using AntraDay4.DataModel;

namespace AntraDay4.Repository;

public class EmployeeRepository : BaseRepository<Employee>
{
    private List<Employee> _employees = new List<Employee>
    {
        new Employee(){Id = 1, Name = "Scott", City = "Sterling", Department = "IT", Salary = 5000},
        new Employee(){Id = 2, Name = "Peter", City = "Sterling", Department = "HR", Salary = 6000},
        new Employee(){Id = 3, Name = "Laura", City = "Leesburg", Department = "IT", Salary = 7000},
        new Employee(){Id = 4, Name = "David", City = "Petersburg", Department = "IT", Salary = 8000},
        new Employee(){Id = 5, Name = "Tracy", City = "Chicago", Department = "HR", Salary = 3000},
        new Employee(){Id = 6, Name = "Fiona", City = "Sterling", Department = "IT", Salary = 2000},
        new Employee(){Id = 7, Name = "Kimad", City = "Sterling", Department = "IT", Salary = 4000}
    };
    
    public List<Employee> Search(Predicate<Employee> Condition)
    {
        List<Employee> result = new List<Employee>();
        foreach (var employee in _employees)
        {
            if (Condition(employee))
            {
                result.Add(employee);
            }
        }

        return result;
    }
}