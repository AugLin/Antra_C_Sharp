namespace AntraDay2;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public virtual void PerformWork()
    {
        
    }

    public virtual void Print()
    {
        
    }

    public Employee(int id, string name)
    {
        
    }
}

public class FullTimeEmployee : Employee
{
    public decimal BiweeklyPay { get; set; }
    public string Benefits { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("FullTime Employee work 40 hours a week");
    }

    public override void Print()
    {
        Console.WriteLine("PrintSomething");
    }

    public FullTimeEmployee(int id, string name): base (id, name)
    {
        
    }
}

public sealed class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("PartTime Employee work 20 hours a week");
    }

    public PartTimeEmployee(int id, string name): base (id, name)
    {
        
    }
}

public class Manager : FullTimeEmployee
{
    public decimal ExtraBonus { get; set; }

    public void AttendMeeting()
    {
        Console.WriteLine("Managers have to Attend Meeting");
    }

    public Manager(int id, string name, decimal bonus) : base(id, name)
    {
        
    }
}