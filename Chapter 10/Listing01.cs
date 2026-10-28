using System.Xml.Linq;

namespace Chapter10;

// ---- Code Listing 01 ----
public static class Listing01
{
    public static void Run()
    {
        string xmlData = @"<Authors>
  <Author>Joydip Kanjilal</Author>
  <Author>Steve Smith</Author>
  <Author>Anand Naraswamy</Author>
  <Author>Yeshwant Kanetkar</Author>
</Authors>";

        XDocument xDocument = XDocument.Parse(xmlData);

        var result = xDocument.Element("Authors")!.Descendants();
        foreach (XElement element in result)
        {
            Console.WriteLine(element.Value);
        }

        xDocument.Element("Authors")!.AddFirst(new XElement("Author", "Michael Smith"));
        result = xDocument.Element("Authors")!.Descendants();
        foreach (XElement element in result)
        {
            Console.WriteLine(element.Value);
        }

        xDocument.Element("Authors")!.Add(new XElement("Author", "Michael Smith"));
        result = xDocument.Element("Authors")!.Descendants();
        foreach (XElement element in result)
        {
            Console.WriteLine(element.Value);
        }

        xDocument.Descendants().Where(s => s.Value == "Anand Naraswamy").Remove();
        result = xDocument.Element("Authors")!.Descendants();
        foreach (XElement element in result)
        {
            Console.WriteLine(element.Value);
        }

        xDocument.Descendants().Where(s => s.Value == "Michael Smith").Remove();
        result = xDocument.Element("Authors")!.Descendants();
        foreach (XElement element in result)
        {
            Console.WriteLine(element.Value);
        }
    }
}
