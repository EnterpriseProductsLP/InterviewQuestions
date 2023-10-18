namespace Answers;

public static class SummationExtensions
{
    /// <summary>
    /// Sums the integers in an array.
    /// </summary>
    /// <param name="values">The values to sum.</param>
    /// <returns>The sum of the given values.</returns>
    public static int Sum(this int[] values)
    {
        var result = 0;
        for (var i = 0; i < values.Length; i++)
        {
            result += values[i];
        }

        return result;
    }
}