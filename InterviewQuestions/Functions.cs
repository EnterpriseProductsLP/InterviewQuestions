using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var product = 0;
            for (var i = 0; i < b; i++)
            {
                product += a;
            }

            return product;
        }

        private static bool ResultShouldBeNegative(int a, int b)
        {
            return (a < 0 && b > 0) || (a > 0 && b < 0);
        }

        public static int Abs(int i)
        {
            return i < 0 ? 0 - i : i;
        }
    }
}