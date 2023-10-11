using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheSecondParameterIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        return 10.Times(0);
    }
}