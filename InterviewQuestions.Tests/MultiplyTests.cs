using FluentAssertions;
using NUnit.Framework;

namespace InterviewQuestions.Tests
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void MultiplyShouldReturnNegativeSixFromNegativeTwoTimesThree()
        {
            var result = Functions.Multiply(-2, 3);
            result.Should().Be(-6);
        }

        [Test]
        public void MultiplyShouldReturnNegativeSixFromTwoTimesNegativeThree()
        {
            var result = Functions.Multiply(2, -3);
            result.Should().Be(-6);
        }

        [Test]
        public void MultiplyShouldReturnSixFromTwoTimesThree()
        {
            var result = Functions.Multiply(2, 3);
            result.Should().Be(6);
        }
    }
}