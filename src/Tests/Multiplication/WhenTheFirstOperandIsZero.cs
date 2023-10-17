using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheFirstOperandIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        const int x = 0;
        const int y = 10;
        return x.Times(y);
    }
}