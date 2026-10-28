// ---- Code Listing 3 & Code Listing 4 ----
public class Person
{
    [PersonValidator("First Name", true, "First Name cannot be empty")]
    public string First { get; set; } = string.Empty;

    [PersonValidator("Last Name", true, "Last Name cannot be empty")]
    public string LastName { get; set; } = string.Empty;

    [PersonValidator("Address", false, "Address must be at least 5 characters",
        @"^.{5,}$", "Length >= 5 chars")]
    public string Address { get; set; } = string.Empty;

    [PersonValidator("Email Address", true, "Invalid email format",
        @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", "Valid email regex")]
    public string Email { get; set; } = string.Empty;

    [PersonValidator("Phone", false, "Invalid phone format",
        @"^\+?1?[-.\s]?\(?([0-9]{3})\)?[-.\s]?([0-9]{3})[-.\s]?([0-9]{4})$",
        "Phone: (123) 456-7890")]
    public string Phone { get; set; } = string.Empty;
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class PersonValidatorAttribute : Attribute
{
    public string DisplayName { get; }
    public bool IsRequired { get; }
    public string ValidationMessage { get; }
    public string Pattern { get; }
    public string CustomValidation { get; }

    public PersonValidatorAttribute(string displayName, bool isRequired = false,
        string validationMessage = "",
        string pattern = "", string customValidation = "")
    {
        DisplayName = displayName;
        IsRequired = isRequired;
        ValidationMessage = validationMessage;
        Pattern = pattern;
        CustomValidation = customValidation;
    }
}
