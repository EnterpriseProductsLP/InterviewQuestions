using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            if (b == 0) { return 0;}
            if (a > b)
            {
                int swap = b;
                b = a;
                a = swap;
            }
            bool negative = a < 0;
            if (negative) { a = -a; }
            int retval = 0;
            for (int i = 0; i < a; i++)
            {
                retval += b;
            }
            if (negative) { retval = -retval;}
            return retval;
        }
    }
}
