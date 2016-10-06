using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            var multiplier = absA > absB 
                ? absB 
                : absA;
            var multiplicand = absA <= absB 
                ? absB 
                : absA;
            var product = 0;

            for (var i = 0; i < multiplier; i ++)
            {
                product += multiplicand;
            }

            if (a < 0 && b > 0 || a > 0 && b < 0)
            {
                product = 0 - product;
            }

            return product;
        }
    }
}
