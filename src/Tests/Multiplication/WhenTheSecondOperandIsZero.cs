using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheSecondOperandIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        return 10.Times(0);
    }
}