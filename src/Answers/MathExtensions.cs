namespace Answers;

public static class MathExtensions
{
    /// <summary>Multiplies two integers.</summary>
    /// <param name="x">The first operand.</param>
    /// <param name="y">The second operand.</param>
    /// <returns>The product of x and y.</returns>
    /// <remarks>
    ///     When implementing this method:
    ///     * You may not use the asterisk(*) symbol.
    ///     * You may not use any linq statements.
    /// </remarks>
    public static int Times(this int x, int y)
    {
        if (EitherOperandIsZero(x, y))
        {
            return 0;
        }

        var absX = Math.Abs(x);
        var absY = Math.Abs(y);

        if (absX > absY)
        {
            (absX, absY) = (absY, absX);
        }

        var result = 0;
        for (var i = 0; i < absX; i++)
        {
            result += absY;
        }

        return ResultShouldBeNegative(x, y) ? -result : result;
    }

    private static bool EitherOperandIsZero(int x, int y)
    {
        return x == 0 || y == 0;
    }

    private static bool ResultShouldBeNegative(int x, int y)
    {
        return (x > 0 && y < 0) || (x < 0 && y > 0);
    }
}