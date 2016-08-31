using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var result = 0;

            if (a == 0 || b == 0)
            {
                return 0;
            }

            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            if (absA > absB)
            {
                var temp = absA;
                absA = absB;
                absB = temp;
            }

            for (var i = 0; i < absA; i++)
            {
                result += absB;
            }

            if ((a < 0 && b > 0) || (a > 0 && b < 0))
            {
                return 0 - result;
            }

            return result;
        }
    }
}
