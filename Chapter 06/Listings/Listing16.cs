namespace Chapter6;

// ---- Code Listing 16 ----
public class MultidimensionalIndexer
{
    private readonly int[,] data = new int[3, 3];

    public int this[int row, int col]
    {
        get => data[row, col];
        set => data[row, col] = value;
    }
}

public static class Listing16
{
    public static void Run()
    {
        MultidimensionalIndexer multidimensionalIndexer = new MultidimensionalIndexer();

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                multidimensionalIndexer[r, c] = r + c;
            }
        }

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write("{0}\t", multidimensionalIndexer[r, c]);
            }

            Console.WriteLine("\n");
        }

    }
}
