// ---- Code Listing 2 ----

[Serializable]
public class PersonSerializable(string FirstName, string LastName)
{
    [NonSerialized]
    private DateTime _dateOfBirth;

    [Obsolete("This method is deprecated")]
    public string GetName()
    {
        return FirstName[0] + "" + LastName[0];
    }

    public string GetInitials()
    {
        return string.Concat(FirstName[0], LastName[0]);
    }
}

public static class Listing02
{
    public static void Run()
    {
        PersonSerializable person = new PersonSerializable("Joydip", "Kanjilal");
        Console.WriteLine($"Initials: {person.GetInitials()}");
    }
}
