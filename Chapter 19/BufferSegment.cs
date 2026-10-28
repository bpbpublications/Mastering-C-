using System;
using System.Buffers;

public class BufferSegment : ReadOnlySequenceSegment<byte>
{
    public BufferSegment(ReadOnlyMemory<byte> memory) => Memory = memory;

    public BufferSegment Append(ReadOnlyMemory<byte> memory)
    {
        var segment = new BufferSegment(memory) { RunningIndex = RunningIndex + Memory.Length };
        Next = segment;
        return segment;
    }
}
