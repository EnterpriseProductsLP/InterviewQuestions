namespace InterviewQuestions
{
    public static class Functions
    {
        public static int Multiply(int a, int b)
        {
            var retVal = 0;

            if (a > 0 && a < b)
            {
                for (var ind = 0; ind < a; ind++)
                    retVal += b;
            }
            else if (b > 0 && b < a)
            {
                for (var ind = 0; ind < b; ind++)
                    retVal += a;
            }
            else if (a > 0)
            {
                for (var ind = 0; ind < a; ind++)
                    retVal += b;
            }
            else if (b > 0)
            {
                for (var ind = 0; ind < b; ind++)
                    retVal += a;
            }
            else if (a < 0 && a > b)
            {
                for (var ind = a; ind < 0; ind++)
                    retVal -= b;
            }
            else if(a < 0 && b < 0)
            {
               for (var ind = b; ind < 0; ind++)
                    retVal -= a;
            }

            return retVal;
        }
    }
}
