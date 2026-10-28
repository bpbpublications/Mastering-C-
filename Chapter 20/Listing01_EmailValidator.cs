// ---- Code Listing 1 ----
public class EmailValidator
{
    public bool IsValidEmail(string email)
    {
        string pattern =
         @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        return Regex.IsMatch(email, pattern);
    }
}
