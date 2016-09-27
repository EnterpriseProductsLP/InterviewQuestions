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
        public void MultiplyShouldReturnFourFromTwoTimesTwo()
        {
            var result = Functions.Multiply(2, 3);
            result.Should().Be(6);
        }

        [Test]
        public void MultiplyShouldReturnNegativeFourForNegativeTwoTimesTwo()
        {
            var result = Functions.Multiply(-2, 3);
            result.Should().Be(-6);
        }

        [Test]
        public void MultiplyShouldReturnNegativeFourForTwoTimesNegativeTwo()
        {
            var result = Functions.Multiply(2, -3);
            result.Should().Be(-6);
        }

        [Test]
        public void MultiplyShouldReturnNegativeFourForTwoTimesNegativeTwo1()
        {
            var result = Functions.Multiply(-2, -3);
            result.Should().Be(6);
        }

        [Test]
        public void Something()
        {
            var result = Functions.Multiply(Int32.MaxValue, 2);
            var maxValue = Int32.MaxValue;
            result.Should().Be(maxValue * 2);
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

        [Test]
        public void MultiplyShouldRunInSimilarTimesForDramaticallyDifferentNegativeOperands()
        {
            var sw = new Stopwatch();
            sw.Start();

            var firstResult = Functions.Multiply(2, -100000000);
            sw.Stop();
            var firstTime = sw.ElapsedMilliseconds;

            sw.Restart();

            var secondResult = Functions.Multiply(-100000000, 2);
            sw.Stop();
            var secondTime = sw.ElapsedMilliseconds;

            var timeDifference = Math.Abs(firstTime - secondTime);

            firstResult.Should().Be(secondResult);
            timeDifference.Should().BeLessThan(5);
        }
    }
}
