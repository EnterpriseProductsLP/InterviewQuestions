namespace Tests;

public abstract class IntFunctionTest
{
    protected int Result { get; private set; }

    protected abstract int ExpectedResult { get; }

    [OneTimeSetUp]
    public void ArrangeAndAct()
    {
        Result = GetResult();
    }

    [Test]
    public void TheResultShouldBeCorrect()
    {
        Result.Should().Be(ExpectedResult);
    }

    protected abstract int GetResult();
}