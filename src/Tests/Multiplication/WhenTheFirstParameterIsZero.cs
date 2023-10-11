using Answers;

namespace Tests.Multiplication;

[TestFixture]
public class WhenTheFirstParameterIsZero : IntFunctionTest
{
    protected override int ExpectedResult => 0;

    protected override int GetResult()
    {
        return 0.Times(10);
    }
}