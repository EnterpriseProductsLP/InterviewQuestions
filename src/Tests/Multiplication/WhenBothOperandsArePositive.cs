using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenBothOperandsArePositive : IntFunctionTest
{
    protected override int ExpectedResult => 100;

    protected override int GetResult()
    {
        return 10.Times(10);
    }
}