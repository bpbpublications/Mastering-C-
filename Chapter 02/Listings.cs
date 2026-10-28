using Chapter2ClassLib;

namespace Chapter2;

// ---- Code Listing 1 ----
public static class Listing01
{
    public static void Run()
    {
        Console.WriteLine("Hello World!");
        Console.Read();
    }
}

// ---- Code Listing 2 ----
public static class Listing02
{
    public static void Run()
    {
        string dayOfWeek = "Sunday";
        string dayType = dayOfWeek switch
        {
            "Saturday" or "Sunday" => "Weekend",
            _ => "Weekday"
        };
        Console.WriteLine(dayType);
    }
}

// ---- Code Listing 3 ----

// ---- Code Listing 4 ----
public static class Listing04
{
    public static void Run()
    {
        TextManager textManager = new TextManager();
        Console.WriteLine(textManager.GetDisplayMessage());
        Console.Read();
    }
}

// ---- Code Listing 5 ----
public static class Listing05
{
    public static void Run()
    {
        bool isValid = true;
        if (isValid)
        {
            Console.WriteLine("The value of the variable isValid is true.");
        }
        else
        {
            Console.WriteLine("The value of the variable isValid is false.");
        }
    }
}

// ---- Code Listing 6 ----
public static class Listing06
{
    public static void Run()
    {
        int marks = 75;
        if (marks >= 80)
        {
            Console.WriteLine("Distinction");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("First division");
        }
        else
        {
            Console.WriteLine("Work harder!");
        }
    }
}

// ---- Code Listing 7 ----
public static class Listing07
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if ((number % 2) == 0)
        {
            Console.WriteLine("{0} is an even number", number);
        }
        else
        {
            Console.WriteLine("{0} is an odd number", number);
        }
        Console.Read();
    }
}

// ---- Code Listing 8 ----

// ---- Code Listing 9 ----
public static class Listing09
{
    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}

// ---- Code Listing 10 ----
public static class Listing10
{
    public static void Run()
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}

// ---- Code Listing 11 ----
public static class Listing11
{
    public static void Run()
    {
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine(i++);
        }
    }
}

// ---- Code Listing 12 ----
public static class Listing12
{
    public static void Run()
    {
        int i = 1;
        do
        {
            Console.WriteLine(i++);
        } while (i <= 10);
    }
}

// ---- Code Listing 13 ----
public static class Listing13
{
    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i > 5) break;
            Console.WriteLine(i);
        }
        Console.Read();
    }
}

// ---- Code Listing 14 ----
public static class Listing14
{
    public static void Run()
    {
        int i = 1;
        while (i <= 10)
        {
            if (i > 5) break;
            Console.WriteLine(i);
            i++;
        }
    }
}

// ---- Code Listing 15 ----
public static class Listing15
{
    public static void Run()
    {
        int i = 1;
        do
        {
            if (i > 5) break;
            Console.WriteLine(i++);
        } while (i <= 10);
    }
}

// ---- Code Listing 16 ----
public static class Listing16
{
    public static void Run()
    {
        string[] languages = { "C#", "F#", "VB.NET" };
        foreach (string language in languages)
        {
            Console.WriteLine(language);
        }
    }
}

// ---- Code Listing 17 ----
public static class Listing17
{
    public static void Run()
    {
        int a = 10, b = 3;
        int sum = a + b;
        bool isGreater = a > b;
        bool result = (a > 5) && (b < 5);
        int bitwiseAnd = a & b;
        a += 5;
        int size = sizeof(int);

        Console.WriteLine($"sum={sum}, isGreater={isGreater}, result={result}, " +
            $"bitwiseAnd={bitwiseAnd}, a={a}, size={size}");
    }
}

// ---- Code Listing 18 ----
public static class Listing18
{
    public static void Run()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
            if (i == 5)
                break;
        }
    }
}

// ---- Code Listing 19 ----
public static class Listing19
{
    public static void Run()
    {
        for (int i = 0; i <= 5; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("End of loop");

                // ---- Code Listing 20 ----
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

// ---- Code Listing 20 ----
public static class Listing20
{
    public static void Run()
    {
        Console.WriteLine("(Listing 20 is the continuation of Listing 19's for-loop; see Listing19.Run())");
    }
}

// ---- Code Listing 21 ----
public static class Listing21
{
    public static void Run()
    {
        int i = 0;
    MyJumpInstruction:
        Console.WriteLine("The value of i is: " + i);
        if (++i < 5)
            goto MyJumpInstruction;
    }
}

// ---- Code Listing 22 ----
public static class Listing22
{
    public static void Run()
    {
        int x = 10;
        object obj = x;
        x = (int)obj;
        Console.WriteLine($"x = {x}");
    }
}
