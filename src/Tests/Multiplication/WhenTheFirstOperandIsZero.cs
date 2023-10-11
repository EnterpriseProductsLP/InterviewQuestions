using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheFirstOperandIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        return 0.Times(10);
    }
}