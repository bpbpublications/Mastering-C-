// ---- Code Listing 14 (executable part) ----
using System.Reflection;

public static class Listing14
{
    public static void Run()
    {
        Type typePerson = typeof(PersonRequiredExample);

        foreach (PropertyInfo prop in typePerson.GetProperties())
        {
            if (prop.GetCustomAttribute(typeof(RequiredAttribute), false) != null)
                Console.WriteLine($"Prop: {prop.Name} is Required");
        }
    }
}
