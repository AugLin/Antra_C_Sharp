/*
Test your Knowledge
1. Describe the problem generics address.
    Generic addresses the issue of different input parameters in a same function. This will avoid DRY principle

2. How would you create a list of strings, using the generic List class?
    List<string> list = new List<string>();
    
3. How many generic type parameters does the Dictionary class have?
    Dictionary will have two types, TKey and TVal. The type of them can be different
    
4. True/False. When a generic class has multiple type parameters, they must all match.
    False

5. What method is used to add items to a List object?
    List.add()
    
6. Name two methods that cause items to be removed from a List.
    List.clear()
    List.Remove()
    List.RemoveAll()
    List.RemoveAt()

7. How do you indicate that a class has a generic type parameter?
    If a class has <T> following by the name of the class

8. True/False. Generic classes can only have one generic type parameter.
    False
    
9. True/False. Generic type constraints limit what can be used for the generic type.
    True
    
10. True/False. Constraints let you use the methods of the thing you are constraining to.
    True
*/

/*
1. Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
1. int Count()
2. T Pop()
3. Void Push()
*/

using AntraCSHW3;
using AntraCSHW3.DataModel;
using AntraCSHW3.Repository;

MyStack<string> myStack = new MyStack<string>();
myStack.Push("Hello");
Console.WriteLine(myStack.Count());

myStack.Push("World");
Console.WriteLine(myStack.Count());

Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.Pop());

Console.WriteLine("========================");

/*
2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)
 */
MyList<string> myList = new MyList<string>();
myList.Add("Hello");
myList.Add("World");
myList.DeleteAt(0);
Console.WriteLine(myList.Find(0));
myList.Add("Word3");
Console.WriteLine(myList.Find(1));
Console.WriteLine(myList.contains("Hello"));

Console.WriteLine("Before Insert");
Console.WriteLine(myList.Find(0));
Console.WriteLine(myList.Find(1));
Console.WriteLine("After Insert");
myList.InsertAt("Inserted Word", 1);
Console.WriteLine(myList.Find(0));
Console.WriteLine(myList.Find(1));
Console.WriteLine(myList.Find(2));

Console.WriteLine("Removing Index 1");
myList.DeleteAt(1);
Console.WriteLine(myList.Find(0));
Console.WriteLine(myList.Find(1));


/*
3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)
 */

ProductRepository pd = new ProductRepository();
Product p1 = new Product();
Product p2 = new Product();
Product p3 = new Product();
p1.ProductId = 1;
p2.ProductId = 2;
p3.ProductId = 3;

p1.ProductName = "P1";
p2.ProductName = "P2";
p3.ProductName = "P3";

p1.ProductPrice = 100;
p2.ProductPrice = 200;
p3.ProductPrice = 300;

pd.Add(p1);
pd.Add(p2);
pd.Add(p3);

pd.Save(1);
pd.Save(2);
pd.Save(3);

Console.WriteLine("==========================");

pd.Remove(p2);
pd.Save(1);
pd.Save(2);
pd.Save(3);