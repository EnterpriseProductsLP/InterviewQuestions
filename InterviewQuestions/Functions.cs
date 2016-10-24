using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var product = 0;
            bool productShouldBeNegative = (a > 0 && b < 0) || (a < 0 && b > 0);

            var multiplier = Math.Abs(a);
            var multiplicand = Math.Abs(b);

            if (multiplier > multiplicand)
            {
                for (int i = 0; i < multiplicand; i++)
                {
                    product += multiplier;
                }
            }
            else
            {
                for (int i = 0; i < multiplier; i++)
                {
                    product += multiplicand;
                }
            }

            return productShouldBeNegative ? 0 - product : product;
        }
    }
}