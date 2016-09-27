using System;
using System.Diagnostics;
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
        public void MultiplyShouldReturnSixFromNegativeTwoTimesNegativeThree()
        {
            var result = Functions.Multiply(-2, -3);
            result.Should().Be(6);
        }

        [Test, ExpectedException(typeof(ArithmeticException))]
        public void MultiplyShouldHandleMaxInt()
        {
            var result = Functions.Multiply(int.MaxValue, int.MaxValue);
        }

        [Test]
        public void MultiplyShouldHandleZeroInFirstParam()
        {
            var result = Functions.Multiply(0, 3);
            result.Should().Be(0);
        }

        [Test]
        public void MultiplyShouldHandleZeroInSecondParam()
        {
            var result = Functions.Multiply(3, 0);
            result.Should().Be(0);
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

        [Test]
        public void MultiplyShouldRunInSimilarTimesForDramaticallyDifferentOperands()
        {
            var sw = new Stopwatch();
            sw.Start();

            var firstResult = Functions.Multiply(-2, 100000000);
            sw.Stop();
            var firstTime = sw.ElapsedMilliseconds;

            sw.Restart();

            var secondResult = Functions.Multiply(100000000, -2);
            sw.Stop();
            var secondTime = sw.ElapsedMilliseconds;

            var timeDifference = Math.Abs(firstTime - secondTime);

            firstResult.Should().Be(secondResult);
            timeDifference.Should().BeLessThan(5);
        }

    }
}
