using Answers;

namespace Tests.Summation;

public class WhenAllValuesArePositive : IntFunctionTest
{
    protected override int ExpectedResult => 15;

    protected override int GetResult()
    {
        var values = new[] {1, 2, 3, 4, 5};
        return values.Sum();
    }
}