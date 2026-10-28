namespace Chapter8;

// ---- Code Listing 6 ----
public class Employee
{
    public int ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}


public class Author
{
    public int ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public static class SampleData
{
    // ---- Code Listing 7 ----
    public static readonly Employee[] Employees =
    {
        new Employee { ID = 1,  FirstName = "Joydip", LastName = "Kanjilal" },
        new Employee { ID = 2,  FirstName = "Sabita", LastName = "Kanjilal" },
        new Employee { ID = 3,  FirstName = "Oindrilla", LastName = "Roy Chowdhury" },
        new Employee { ID = 4,  FirstName = "Soma", LastName = "Roy Chowdhury" },
        new Employee { ID = 5,  FirstName = "Hardik", LastName = "Patel" },
        new Employee { ID = 6,  FirstName = "Raghu", LastName = "Ramani" },
        new Employee { ID = 7,  FirstName = "Amit", LastName = "Shah" },
        new Employee { ID = 8,  FirstName = "Kaushal", LastName = "Sen" },
        new Employee { ID = 9,  FirstName = "Abhishek", LastName = "Das" },
        new Employee { ID = 10, FirstName = "Sanket", LastName = "Patel" },
        new Employee { ID = 11, FirstName = "Dinesh", LastName = "Trivedi" },
        new Employee { ID = 12, FirstName = "Jayesh", LastName = "Saha" },
        new Employee { ID = 13, FirstName = "Chiranjib", LastName = "Dastidar" },
        new Employee { ID = 14, FirstName = "Shiva", LastName = "Reddy" },
        new Employee { ID = 15, FirstName = "Asha", LastName = "Parek" },
        new Employee { ID = 16, FirstName = "Seema", LastName = "Agarwal" },
        new Employee { ID = 17, FirstName = "Ankit", LastName = "Sohni" },
        new Employee { ID = 18, FirstName = "Sanket", LastName = "Mazumder" },
        new Employee { ID = 19, FirstName = "Tapan", LastName = "Misra" },
        new Employee { ID = 20, FirstName = "Gopal", LastName = "Karmakar" }
    };

    public static readonly Author[] Authors =
    {
        new Author { ID = 1, FirstName = "Joydip", LastName = "Kanjilal" },
        new Author { ID = 2, FirstName = "Jane", LastName = "Austen" },
        new Author { ID = 3, FirstName = "Mark", LastName = "Twain" },
        new Author { ID = 4, FirstName = "John", LastName = "Grisham" },
        new Author { ID = 5, FirstName = "Agatha", LastName = "Christie" }
    };
}
