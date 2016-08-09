using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var min= Math.Min(Math.Abs(a), Math.Abs(b));
            var max = Math.Max(Math.Abs(a), Math.Abs(b));
            int result = 0;
            for (int i = 0; i < min; i++)
                result += max;
            if (a <= 0 && b <= 0)
                result = result;
            else if (a <= 0 || b <= 0)
                result = -result;
            return result;
        }
    }
}
