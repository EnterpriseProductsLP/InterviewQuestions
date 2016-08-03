namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            if (EitherOperandIsZero(a, b))
            {
                return 0;
            }

            var absA = Abs(a);
            var absB = Abs(b);

            if (LoopingIsFasterOnA(absA, absB))
            {
                var temp = absA;
                absA = absB;
                absB = temp;
            }

            var result = 0;
            for (var i = 0; i < absB; ++i)
            {
                result += absA;
            }

            if (ResultShouldBeNegative(a, b))
            {
                return 0 - result;
            }

            return result;
        }

        private static bool LoopingIsFasterOnA(int absA, int absB)
        {
            return absA < absB;
        }

        private static bool EitherOperandIsZero(int a, int b)
        {
            return a == 0 || b == 0;
        }

        private static bool ResultShouldBeNegative(int a, int b)
        {
            return (a < 0 && b > 0) || (a > 0 && b < 0);
        }

        private static int Abs(int i)
        {
            return i >= 0 ? i : 0 - i;
        }
    }
}