using AntraDay3.DataModel;
using AntraDay3.Repository;

namespace AntraDay3.Presentation;

public class ManageCustomer
{
    private CustomerRepository _customerRepository = new CustomerRepository();

    private void AddCustomer()
    {
        Customer c = new Customer();
        Console.WriteLine("Enter Id ==> ");
        c.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name ==> ");
        c.Name = Console.ReadLine();
        Console.WriteLine("Enter Email ==> ");
        c.Email = Console.ReadLine();

        if (_customerRepository.Insert(c) == 1)
        {
            Console.WriteLine("Customer added successfully");
        }
        else
        {
            Console.WriteLine("Customer already exists in the database");
        }
    }

    private void PrintAllCustomers()
    {
        List<Customer> customers = _customerRepository.GetAll();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Customer: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
        }
    }

    private void DeleteCustomer()
    {
        Console.WriteLine("Enter Id ==> ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (_customerRepository.Delete(id) == 1)
        {
            Console.WriteLine("Customer deleted successfully");
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press 1 to Add");
        Console.WriteLine("Press 2 to PrintAll");
        Console.WriteLine("Press 3 to Delete");
        Console.WriteLine("Press 0 to Exit");
        int command = Convert.ToInt32(Console.ReadLine());

        while (command != 0)
        {
            switch (command)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2: 
                    PrintAllCustomers();
                    break;
                case 3:
                    DeleteCustomer();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
            Console.WriteLine("Press number to continue");
            command = Convert.ToInt32(Console.ReadLine());
        }
    }
}