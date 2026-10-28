// ---- Code Listing 2 ----
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Appendix;

public static class Listing02
{
    public static void Run()
    {
        if (Environment.GetEnvironmentVariable("RUN_BENCHMARKS") == "1")
        {
            BenchmarkRunner.Run<StringBenchmarks>();
        }
        else
        {
            Console.WriteLine("Skipping BenchmarkRunner.Run<StringBenchmarks>() (set RUN_BENCHMARKS=1 to execute it).");
        }
    }
}

[MemoryDiagnoser]
public class StringBenchmarks
{
    private readonly string _input = "Hello World!";

    [Benchmark(Baseline = true)]
    public string Concatenate() => _input + " Optimized";

    [Benchmark]
    public string Interpolate() => $"{_input} Optimized";
}
