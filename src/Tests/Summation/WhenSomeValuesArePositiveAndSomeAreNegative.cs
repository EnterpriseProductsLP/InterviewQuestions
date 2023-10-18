using Answers;

namespace Tests.Summation;

public class WhenSomeValuesArePositiveAndSomeAreNegative : IntFunctionTest
{
    protected override int ExpectedResult => 3;

    protected override int GetResult()
    {
        var values = new[] {1, -2, 3, -4, 5};
        return values.Sum();
    }
}