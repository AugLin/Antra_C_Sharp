using System.Security.Cryptography;
using AntraDay5.Repositories;

namespace AntraDay5.Presentation;

public class ManageEmployee
{
    private EmployeeRepository employeeRepository = new EmployeeRepository();

    private void SelectDemo()
    {
        // SELECT * FROM Employee
        // Query Syntax
        
        // var result = from employee in employeeRepository.GetEmployees()
        //     select employee;
        
        // Method Syntax
        // var result = employeeRepository.GetEmployees().Select(
        //         employee => employee
        //     );
        
        // Query Syntax
        // var result = from employee in employeeRepository.GetEmployees()
        //     select employee.Name;

        // Method Syntax
        // var result = employeeRepository.GetEmployees().Select(
        //         employee => employee.Name
        //     );
        //
        // foreach (var name in result)
        // {
        //     Console.WriteLine(name);
        // }

        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.Name + "\t " + employee.Department + "\t" + employee.Age);
        // }
        
        // Query Syntax
        // var result = from employee in employeeRepository.GetEmployees()
        //     select new
        //     {
        //         Id = employee.Id,
        //         Name = employee.Name,
        //         Salary = employee.Salary
        //     };
        
        // Method Syntax
        // var result2 = employeeRepository.GetEmployees().Select(
        //    x => new
        //    {
        //        Id = x.Id,
        //        Name = x.Name,
        //        Salary = x.Salary
        //    } 
        // );
        //
        // foreach (var employee in result2)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.Name +  "\t" + "\t" + employee.Salary);
        // }
        
        // Distinct department
        // Query Syntax
        
        // var result = (from employee in employeeRepository.GetEmployees()
        //     select employee.Department).Distinct();
        
        // Method Syntax
        // var result = employeeRepository.GetEmployees().Select(employee => employee.Department).Distinct();
        //
        // foreach (var department in result)
        // {
        //     Console.WriteLine(department);
        // }
        
        // First or FirstOrDefault
        // Method Syntax
        // var result = employeeRepository.GetEmployees().Select(employee => new
        // {
        //     Id = employee.Id,
        //     Name = employee.Name,
        //     Salary = employee.Salary,
        //     Department = employee.Department
        // }).FirstOrDefault(x => x.Department == "ESX")??new
        // {
        //     Id = 0,
        //     Name = "Null",
        //     Salary = 0,
        //     Department = "Null"
        // };
        
        // Console.WriteLine(result.Id + "\t" + result.Name + "\t" + result.Department + "\t" + result.Salary);

        // Single or SingleOrDefault
        var result = employeeRepository.GetEmployees().Select(employee => new
        {
            Id = employee.Id,
            Name = employee.Name,
            Salary = employee.Salary,
            Department = employee.Department
        }).SingleOrDefault(x => x.Department == "ad");
        
        Console.WriteLine(result);

        
    }

    private void OrderBy()
    {
        //Query
        // var result = from employee in employeeRepository.GetEmployees()
        //     orderby employee.Department descending, employee.Name ascending
        //         select new
        //     {
        //         Id = employee.Id,
        //         Name = employee.Name,
        //         Salary = employee.Salary
        //     };
        
        // Method
        var result = employeeRepository.GetEmployees()
            .OrderByDescending(x => x.Department).ThenByDescending(x => x.Id);
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.Name + "\t" + employee.Department + "\t" + employee.Salary);
        }
    }

    private void Where()
    {
        //  Query

        // var result = from employee in employeeRepository.GetEmployees()
        //     where employee.Salary >= 3000 && employee.Salary < 5000
        //     select (employee);
        
        // Method
        var result = employeeRepository.GetEmployees().Where(employee => employee.Salary >= 3000 && employee.Salary < 5000)
            .Select(employee => employee);
        
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.Name + "\t" + employee.Department + "\t" + employee.Salary);
        }
    }

    private void Quantifier()
    {
        // Method Syntax

        var result = employeeRepository.GetEmployees().Any(employee => employee.Salary > 6000);
        Console.WriteLine(result);
    }

    private void GroupBy()
    {
        //Query Syntax
        // var result = from employee in employeeRepository.GetEmployees()
        //     group employee by employee.Department;

        //Method Syntax
        var result = employeeRepository.GetEmployees().GroupBy(employee => employee.Department);
        
        foreach (var group in result)
        {
            foreach (var employee in group)
            {
                Console.WriteLine(employee.Id + "\t" + employee.Name + "\t" + employee.Department + "\t" + employee.Salary);
            }
        }
    }

    private void Aggregation()
    {
        //Method Syntax
        var result = employeeRepository.GetEmployees().Average(employee => employee.Salary);
        
        // Average salary by department
        var avgSalary = employeeRepository.GetEmployees().GroupBy(x => x.Department).Select(
            x => new
            {
                department = x.Key,
                AverageSalary = Math.Round(x.Average(employee => employee.Salary), 2),
                TotalSalary = x.Sum(employee => employee.Salary)
            });
        
        Console.WriteLine(result);

        foreach (var salary in avgSalary)
        {
            Console.WriteLine(salary.department + "\t" + salary.AverageSalary + "\t" + salary.TotalSalary);
        }
    }
    
    public void Run()
    {
        Aggregation();
    }
}