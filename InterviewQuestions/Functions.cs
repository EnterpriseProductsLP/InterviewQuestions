using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int MultiplyAnswer(int a, int b)
        {
            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            var multiplicand = Math.Min(absA, absB);
            var multiplier = Math.Max(absA, absB);

            var product = 0;
            for (var i = 0; i < multiplicand; i++)
            {
                product += multiplier;
            }

            if (ResultShouldBeNegative(a, b))
            {
                return 0 - product;
            }

            return product;
        }

        private static bool ResultShouldBeNegative(int a, int b)
        {
            return (a > 0 && b < 0) || (a < 0 && b > 0);
        }
    }
}