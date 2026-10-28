// ---- Code Listing 12 ----
[Comments("Joydip", "Class", "Employee Entity")]
public class Employee
{
    private string employeeName = string.Empty;
    private int basic;

    [Comments("Joydip", "Property", "Set/Retrieve name of the employee", Status = "Complete")]
    public string Name
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    [Comments("Joydip", "Property", "Set/Retrieve basic salary of the employee", Status = "Complete")]
    public int Basic
    {
        get { return basic; }
        set { basic = value; }
    }

    [Comments("Joydip", "Method", "Display employee details", Status = "Complete")]
    public void Display()
    {
        Console.WriteLine("The name is " + employeeName);
        Console.WriteLine("The basic is " + basic);
    }
}

public static class Listing12
{
    public static void Run()
    {
        Employee employee = new Employee();
        Comments.DisplayAttributes(typeof(Employee));
    }
}
