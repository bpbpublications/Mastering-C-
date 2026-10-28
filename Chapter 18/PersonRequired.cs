// ---- Code Listing 14 (type declarations) ----
[AttributeUsage(AttributeTargets.Property)]
public class RequiredAttribute : Attribute { }

public class PersonRequiredExample
{
    [Required]
    public string Name { get; set; } = string.Empty;
}
