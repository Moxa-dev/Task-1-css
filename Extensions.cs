// ... existing code ...

// Extension method for skipping a specified number of elements
public static IEnumerable<T> Skip<T>(this IEnumerable<T> enumerable, int count)
{
    int skipped = 0;
    foreach (var e in enumerable)
    {
        if (skipped++ >= count)
            yield return e;
    }
}

// Extension method for taking a specified number of elements
public static IEnumerable<T> Take<T>(this IEnumerable<T> enumerable, int count)
{
    int taken = 0;
    foreach (var e in enumerable)
    {
        if (taken++ < count)
            yield return e;
        else
            yield break;
    }
}

// ... existing code ...