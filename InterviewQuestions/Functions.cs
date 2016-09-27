using System;

namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var result = 0;
            //check which number is bigger.
            int x;
            int y;

            if (Math.Abs(a) > Math.Abs(b))
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }


            //To address positive a and b

            if (y > 0)
            {
                for (var i = 1; i <= y; i++)
                {
                    result = result + x;
                }
            }
            else
            {
                for (var i = -1; i >= y; i--)
                {
                    result = result - x;
                }
            }

            return result;
        }


    }
}
