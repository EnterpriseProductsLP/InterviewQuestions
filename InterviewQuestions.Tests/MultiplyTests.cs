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
        public void MultiplyShouldReturnSixA()
        {
            var result = Functions.Multiply(-1, -3);
            result.Should().Be(3);
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
