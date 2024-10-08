namespace AntraDay2;

public class Customer
{
    // Full Version Property
    // Private backing field + get and setMethods
    
    // private string CustomerName;

    // public string CustomerName
    // {
    //      get
    //      {
    //          return CustomerName;
    //      }
    //      set
    //      {
    //          CustomerName = value;
    //      }
    // }
    //
    // Autu-implemented Property
    public string CustomerName { get; set; }
    public int Id { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }

    public Customer()
    {
        
    }
    
    public Customer(string customerName, int id, string email, string phone)
    {
        CustomerName = customerName;
        Id = id;
        Email = email;
        Phone = phone;
    }
    public Customer(string customerName, int id, string email)
    {
        Id = id;
        CustomerName = customerName;
        Email = email;
    }
    
    //  Encapsulation
    //  
}