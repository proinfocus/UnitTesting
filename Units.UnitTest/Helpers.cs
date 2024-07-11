namespace Units.UnitTest;

public static class Helpers
{
    public static void Measure(Action action, int timeout)
    {
        using var cts = new CancellationTokenSource();
        var task = Task.Run(() => {
            action();
        }, cts.Token);

        if (!task.Wait(timeout, cts.Token))
        {
            cts.Cancel();
            cts.Dispose();
            throw new TimeoutException($"Operation timeout as it surpassed {timeout}ms threshold.");
        }

        cts.Dispose();
    }
}
