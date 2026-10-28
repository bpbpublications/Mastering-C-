using System.Collections.Generic;

namespace Chapter10;

public sealed class Author
{
    public int AuthorID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
}

public sealed class BPBEntities : IDisposable
{
    public List<Author> Authors { get; } = new()
    {
        new Author { AuthorID = 1, FirstName = "Joydip", LastName = "Kanjilal", Age = 55 },
        new Author { AuthorID = 2, FirstName = "Steve", LastName = "Smith", Age = 48 },
        new Author { AuthorID = 3, FirstName = "Anand", LastName = "Naraswamy", Age = 60 },
        new Author { AuthorID = 4, FirstName = "Yeshwant", LastName = "Kanetkar", Age = 52 },
    };

    public void Dispose() { }
}
