using System.Diagnostics;

namespace GenericsPerf;

internal class OperationTimer : IDisposable
{
    private long _collectionCount;
    private Stopwatch _stopwatch;
    private string _text;

    internal OperationTimer(string text)
    {
        _collectionCount = GC.CollectionCount(0);
        PrepareForOperation();
        _text = text;
        _stopwatch = Stopwatch.StartNew();

    }

    public void Dispose()
    {
        Console.WriteLine("{0} GCs={1,3} {2}", _stopwatch.Elapsed, GC.CollectionCount(0) - _collectionCount, _text);
    }

    private void PrepareForOperation()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}