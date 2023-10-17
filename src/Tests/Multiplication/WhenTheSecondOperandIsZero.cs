using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheSecondOperandIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        const int x = 10;
        const int y = 0;
        return x.Times(y);
    }
}