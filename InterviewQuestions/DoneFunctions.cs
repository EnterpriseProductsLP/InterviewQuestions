using System;

namespace InterviewQuestions
{
    public static class DoneFunctions
    {
        public static int Multiply(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            var resultIsNegative = (a < 0 && b > 0) || (a > 0 && b < 0);

            var absA = Math.Abs(a);
            var absB = Math.Abs(b);

            if (absA > absB)
            {
                var temp = absB;
                absB = absA;
                absA = temp;
            }

            var result = 0;
            for (var i = 0; i < absA; i++)
            {
                result += absB;
            }

            if (resultIsNegative)
            {
                return 0 - result;
            }

            return result;
        }
    }
}