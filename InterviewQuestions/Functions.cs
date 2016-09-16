using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var returnNegative = (a < 0 && b > 0) || (a > 0 && b < 0);

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (b > a)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            var result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }

            return returnNegative
                ? 0 - result
                : result;
        }
   }
}