using AntraDay2;

Customer c1 = new Customer("Smith", 1, "Smith@gmail.com");
Console.WriteLine(c1.CustomerName);

Customer c2 = new Customer();

Customer c3 = new Customer("Smith", 1, "Smith@gmail.com", "1234567890");
Console.WriteLine($"The phone number for third customer is {c3.Phone}");

// FullTimeEmployee fte = new FullTimeEmployee();
// fte.PerformWork();
//
// PartTimeEmployee pte = new PartTimeEmployee();
// pte.PerformWork();
//
// Manager m = new Manager();
// m.AttendMeeting();

// Addition addition = new Addition();
// Console.WriteLine(addition.AddNumbers(1, 2));
// Console.WriteLine(addition.AddNumbers(1.3, 2.2));

Addition.AddNumbers(1, 2);

Console.WriteLine(18.OddOrEven());