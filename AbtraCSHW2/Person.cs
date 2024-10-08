namespace AbtraCSHW2;

public abstract class Person : IPersonService
{
    
    /*
     *  Person
        Calculate Age of the Person
        Calculate the Salary of the person, Use decimal for salary
        Salary cannot be negative number
        Can have multiple Addresses, should have method to get addresses
     */
    private List<String> Addresses = new List<String>();
    public String Name { get; set; }
    public decimal Salary { get; set; }
    public DateTime Birthday { get; set; }

    public void AddAddress(String address)
    {
        Addresses.Add(address);
    }

    public List<String> GetAddresses()
    {
        return Addresses;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - Birthday.Year;
    }

    public decimal CalculateSalary()
    {
        if (Salary < 0)
        {
            Console.WriteLine("Invalid Salary");
        }
        return Salary;
    }
}
