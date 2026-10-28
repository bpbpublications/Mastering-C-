// ---- Code Listing 1 ----
using System.Runtime;
Console.WriteLine("Allocating large objects...");
byte[] data1 = new byte[100_000];
byte[] data2 = new byte[200_000];
Console.WriteLine("Requesting LOH compaction...");
GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
GC.Collect();
Console.WriteLine("Large Object Heap has been compacted once.");
