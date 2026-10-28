
public static class Listing01
{
    public static void Run()
    {
        int[] numbers = new int[10];
        Console.WriteLine($"Created an int array of length {numbers.Length}.");
    }
}

public static class Listing02
{
    public static void Run()
    {
        int[] numbers = new int[10];
        for (int index = 0; index < 10; index++)
            numbers[index] = index + 1;
        for (int index = 0; index < 10; index++)
            Console.WriteLine(numbers[index]);
    }
}

public static class Listing03
{
    public static void Run()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        Console.WriteLine($"cars: [{string.Join(", ", cars)}]");
        Console.WriteLine($"myNum: [{string.Join(", ", myNum)}]");
    }
}

public static class Listing04
{
    public static void Run()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        cars[0] = "Audi";
        Console.WriteLine($"cars: [{string.Join(", ", cars)}]");
    }
}

public static class Listing05
{
    public static void Run()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        Console.WriteLine(cars[0]);
        Console.WriteLine(myNum[2]);
    }
}

public static class Listing06
{
    public static void Run()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

public static class Listing07
{
    public static void Run()
    {
        int[] source = new int[] { 1, 2, 3, 4, 5 };
        int[] target = source;
        Console.WriteLine($"source: [{string.Join(", ", source)}], target: [{string.Join(", ", target)}] (same reference: {ReferenceEquals(source, target)})");
    }
}

public static class Listing08
{
    public static void Run()
    {
        int[,] array = new int[5, 5];
        Console.WriteLine($"Created a {array.GetLength(0)}x{array.GetLength(1)} 2D array.");
    }
}

public static class Listing09
{
    public static void Run()
    {
        int[,] twoDimensionalArray = new int[,] { { 0, 1 }, { 2, 3 }, { 4, 5 }, { 6, 7 }, { 8, 9 } };
        Console.WriteLine($"twoDimensionalArray has {twoDimensionalArray.GetLength(0)} rows and {twoDimensionalArray.GetLength(1)} columns.");
    }
}

public static class Listing10
{
    public static void Run()
    {
        int[][] arr = new int[2][];
        arr[0] = new int[5] { 1, 3, 5, 7, 9 };
        arr[1] = new int[5] { 2, 4, 6, 8, 10 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write("{0}", arr[i][j]);
                Console.Write("\t");
            }

            Console.WriteLine("");
        }
    }
}

public static class Listing11
{
    public static void Run()
    {
        int[,] seats = new int[5, 10];
        seats[2, 3] = 1;
        seats[0, 0] = 1;
        seats[4, 9] = 1;

        for (int row = 0; row < seats.GetLength(0); row++)
        {
            Console.Write("Row " + (row + 1) + ": ");
            for (int col = 0; col < seats.GetLength(1); col++)
            {
                Console.Write(seats[row, col] == 1 ? "[X] " : "[ ] ");
            }
            Console.WriteLine();
        }
    }
}

public static class Listing12
{
    public static void Run()
    {

        int[,] studentGrades = new int[3, 3]
        {
            { 85, 92, 78 },
            { 88, 79, 94 },
            { 90, 91, 85 }
        };

        string[] subjects = { "Math", "English", "Science" };
        for (int student = 0; student < studentGrades.GetLength(0); student++)
        {
            Console.Write("Student " + (student + 1) + " grades: ");
            for (int subject = 0; subject < studentGrades.GetLength(1); subject++)
            {
                Console.Write(subjects[subject] + ": " +
                studentGrades[student, subject] + "  ");
            }
            Console.WriteLine();
        }
    }
}

public static class Listing13
{
    public static void Run()
    {
        int[] numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
        Console.WriteLine("Original Array:");
        foreach (var n in numbers) Console.Write(n + " ");
        Console.WriteLine();

        Array.Sort(numbers);
        Console.WriteLine("Sorted Array:");
        foreach (var n in numbers) Console.Write(n + " ");
        Console.WriteLine();
    }
}
