namespace Chapter10;

// ---- Code Listing 02 ----
public static class Listing02
{
    public static void Run()
    {
        using BPBEntities context = new BPBEntities();

        var query = context.Authors
            .Select(author => new
            {
                AuthorId = author.AuthorID,
                FirstName = author.FirstName,
                LastName = author.LastName
            });

        foreach (var data in query)
        {
            Console.WriteLine(
                "Author Id: {0} First name: {1} Last name: {2}",
                data.AuthorId,
                data.FirstName,
                data.LastName
            );
        }
    }
}
