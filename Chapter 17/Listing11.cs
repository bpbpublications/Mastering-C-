// ---- Code Listing 11 ----
using System.Reflection;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class Comments : Attribute
{
    public string author = string.Empty;
    public string type = string.Empty;
    public string description = string.Empty;
    private string status = string.Empty;

    public Comments(string author, string type, string description)
    {
        this.author = author;
        this.type = type;
        this.description = description;
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public static void DisplayAttributes(Type t)
    {
        Comments? comments = (Comments?)Attribute.GetCustomAttribute(t, typeof(Comments));
        Console.WriteLine("The Author is: {0}.", comments?.author);
        Console.WriteLine("The Description is: {0}.", comments?.description);
        Console.WriteLine("Class Name: {0}", t.Name);
        MethodInfo[] methods = t.GetMethods();
        object[] attributes;
        for (int i = 0, l = methods.GetLength(0); i < l; i++)
        {
            MethodInfo mi = methods[i];
            attributes = mi.GetCustomAttributes(true);
            foreach (Attribute attribute in attributes)
            {
                if (attribute is Comments)
                {
                    Comments theComments = (Comments)attribute;
                    Console.WriteLine("Name: {0}, Type: {1}, Purpose: {2}, Created By: {3}",
                        mi.Name, theComments.type, theComments.description, theComments.author);
                }
            }
        }
    }
}

public static class Listing11
{
    public static void Run()
    {
        Console.WriteLine("Listing 11 declares the Comments attribute (see the Comments class above); Employee is reunited from Listings 11-12 in Listing12.cs.");
    }
}
