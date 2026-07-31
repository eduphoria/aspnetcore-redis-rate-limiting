using System;
using System.Diagnostics;

namespace RedisRateLimiting;

internal static class StopwatchExtensions
{
    public static TimeSpan GetElapsedTime(long startingTimestamp)
    {
        var elapsedTimestamp = Stopwatch.GetTimestamp() - startingTimestamp;
        return TimeSpan.FromSeconds((double)elapsedTimestamp / Stopwatch.Frequency);
    }
}
