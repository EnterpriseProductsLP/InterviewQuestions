using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace InterviewQuestions.Tests
{
    [TestFixture]
    public class AllMultiplyTests
    {
        [Test]
        public void MultiplyReturnsZeroWhenFirstOperandIsZero()
        {
            var result = Functions.Multiply(0, 1);
            result.Should().Be(0);
        }

        [Test]
        public void MultiplyShouldReturnZeroWhenSecondOperandIsZero()
        {
            var result = Functions.Multiply(1, 0);
            result.Should().Be(0);
        }

        [Test]
        public void MultiplyShouldReturnFourFromTwoTimesTwo()
        {
            var result = Functions.Multiply(2, 2);
            result.Should().Be(4);
        }

        [Test]
        public void MultiplyShouldReturnNegativeFourForNegativeTwoTimesTwo()
        {
            var result = Functions.Multiply(-2, 2);
            result.Should().Be(-4);
        }

        [Test]
        public void MultiplyShouldReturnNegativeFourForTwoTimesNegativeTwo()
        {
            var result = Functions.Multiply(2, -2);
            result.Should().Be(-4);
        }

        [Test]
        public void MultiplyShouldReturnFourFromNegativeTwoTimesNegativeTwo()
        {
            var result = Functions.Multiply(-2, -2);
            result.Should().Be(4);
        }

        [Test]
        public void MultiplyShouldRunInSimilarTimesForDramaticallyDifferentOperands()
        {
            var sw = new Stopwatch();
            sw.Start();

            var firstResult = Functions.Multiply(2, 100000000);
            sw.Stop();
            var firstTime = sw.ElapsedMilliseconds;

            sw.Restart();

            var secondResult = Functions.Multiply(100000000, 2);
            sw.Stop();
            var secondTime = sw.ElapsedMilliseconds;

            var timeDifference = Math.Abs(firstTime - secondTime);

            firstResult.Should().Be(secondResult);
            timeDifference.Should().BeLessThan(5);
        }
    }
}
