using System;

namespace Console1.service
{
    public class MyMath
    {
        public static int FibLoop(int x)
        {
            if (x < 2)
            {
                return x;
            }
            
            var a = 0;
            var b = 1;
            
            for (var i = 2; i < x; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }
            return a + b;
        }

        public static int FibRecursive(int x)
        {
            if (x < 2)
            {
                return x;
            }
            
            return fibIter(x, 2, 0, 1);
        }

        private static int fibIter(int x, int i, int a, int b)
        {
            if (i == x)
            {
                return a + b;
            }
            
            return fibIter(x, i + 1, b, a + b);
        }
    }
}