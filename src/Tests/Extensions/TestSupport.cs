namespace Tests.Extensions;

public static class TestSupport
{
    public static long AbsoluteDifference(this long x, long y)
    {
        if (x > y) return x - y;

        return y - x;
    }
}