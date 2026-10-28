// ---- Code Listing 5 ----
using System.Reflection;
using System.Text.RegularExpressions;

public static class Listing05
{
    public static void Run()
    {
        var personInstance = new Person
        {
            First = "Joydip",
            LastName = "",
            Address = "123",
            Email = "not-an-email",
            Phone = ""
        };
        ValidateAndInspectMetadata(personInstance);
    }

    static void ValidateAndInspectMetadata(Person personInstance)
    {
        var type = personInstance.GetType();
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var property in properties)
        {
            var value = property.GetValue(personInstance);
            var attribute = property.GetCustomAttribute<PersonValidatorAttribute>();
            Console.WriteLine($"Property: {property.Name}");
            Console.WriteLine($"Value: '{value}'");

            if (attribute != null)
            {
                Console.WriteLine($"Display Name: {attribute.DisplayName}");
                Console.WriteLine($"Required: {attribute.IsRequired}");
                bool isValid = IsValid(value, attribute);
                Console.WriteLine($"Valid: {isValid}");
                if (!isValid && !string.IsNullOrWhiteSpace(attribute.ValidationMessage))
                    Console.WriteLine($"Error: {attribute.ValidationMessage}");
            }
            else
            {
                Console.WriteLine("No PersonValidator attribute found.");
            }
            Console.WriteLine();
        }
    }

    static bool IsValid(object? value, PersonValidatorAttribute attr)
    {
        var text = value?.ToString();
        if (attr.IsRequired && string.IsNullOrWhiteSpace(text))
            return false;
        if (string.IsNullOrWhiteSpace(text))
            return true;
        if (!string.IsNullOrEmpty(attr.Pattern))
            return Regex.IsMatch(text, attr.Pattern);
        return true;
    }
}
