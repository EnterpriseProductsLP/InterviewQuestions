using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            int product = 0;
            if (Math.Abs(a) > Math.Abs(b))
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = 1; i <= Math.Abs(a); i++)
            {
                if (b < 0)
                    product -= b;
                else
                    product += b;
            }

            if ((a < 0) || (b < 0))
                return 0 - product;
            else
                return product;
        }
    }
}