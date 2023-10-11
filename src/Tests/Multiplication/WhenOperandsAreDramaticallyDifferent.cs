using System.Diagnostics;
using Answers;
using Tests.Extensions;

namespace Tests.Multiplication;

[TestFixture]
public class WhenOperandsAreDramaticallyDifferent
{
    [OneTimeSetUp]
    public void ArrangeAndAct()
    {
        // Make a stopwatch to measure performance.
        var sw = new Stopwatch();

        // Create dramatically different operands to test performance.
        var x = 2;
        var y = ExpectedResult / 2;

        // Multiply with the smaller operand on the left and time the operation.
        sw.Start();
        _firstResult = x.Times(y);
        sw.Stop();
        _firstMeasurement = sw.ElapsedTicks;

        // Multiply with the larger operand on the left and time the operation.
        sw.Restart();
        _secondResult = y.Times(x);
        sw.Stop();
        _secondMeasurement = sw.ElapsedTicks;
    }

    private long _firstMeasurement;
    private int _firstResult;
    private long _secondMeasurement;
    private int _secondResult;

    private const int ExpectedResult = int.MaxValue - 1;

    [Test]
    public void TheResultsShouldBeCorrect()
    {
        _firstResult.Should().Be(ExpectedResult);
        _secondResult.Should().Be(ExpectedResult);
    }

    [Test]
    public void ThePerformanceShouldBeSimilar()
    {
        // Get the raw performance delta in ticks.
        var ticksDelta = _secondMeasurement.AbsoluteDifference(_firstMeasurement);
        var millisecondsDelta = ticksDelta / TimeSpan.TicksPerMillisecond;
        millisecondsDelta.Should().BeLessThan(5);
    }
}