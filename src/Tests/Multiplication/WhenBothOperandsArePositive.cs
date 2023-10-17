using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenBothOperandsArePositive : IntFunctionTest
{
    protected override int ExpectedResult => 100;

    protected override int GetResult()
    {
        const int x = 10;
        const int y = 10;
        return x.Times(y);
    }
}