using System.Xml.Serialization;

namespace Chapter15;

// ---- Code Listing 6 ----
public static class SerializationHelper
{
    public static void Serialize(Author author, string filename)
    {
        XmlSerializer? serializer = null;
        FileStream? stream = null;
        try
        {
            serializer = new XmlSerializer(typeof(Author));
            stream = new FileStream(filename, FileMode.Create);
            serializer.Serialize(stream, author);
        }
        finally
        {
            if (stream != null) stream.Close();
        }
    }

    public static Author Deserialize(string filename)
    {
        XmlSerializer? serializer = null;
        FileStream? stream = null;
        try
        {
            serializer = new XmlSerializer(typeof(Author));
            stream = new FileStream(filename, FileMode.Open);
            return (Author)serializer.Deserialize(stream)!;
        }
        finally
        {
            if (stream != null)
                stream.Close();
        }
    }
}

// ---- Code Listing 7 ----
public static class Listing07
{
    public static void Run()
    {
        Author author = new Author();
        author.Id = 1;
        author.FirstName = "Joydip";
        author.LastName = "Kanjilal";
        author.Address = "Hyderabad, India";
        SerializationHelper.Serialize(author, @"D:\author.xml");
        author = SerializationHelper.Deserialize(@"D:\author.xml");
        Console.WriteLine(author.Id + "\t" + author.FirstName + "\t" + author.LastName + "\t" + author.Address);
    }
}
