using System;
using System.Text.RegularExpressions;

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

            var resultShouldBeNegative = (a < 0 && b > 0) || (a > 0 && b < 0);

            int c = 0;

            int absA = Math.Abs(a);
            int absB = Math.Abs(b);

            if (absA > absB)
            {
                var temp = absB;
                absB = absA;
                absA = temp;
            }

            for (int i = 0; i < absA; i++)
            {
                c += absB;

            }

            if (resultShouldBeNegative)
            {
                return 0 - c;
            }

            return c;

        }
    }
}