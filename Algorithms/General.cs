using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class General
    {
        public static IEnumerable<int> Fibonacci(int max)
        {
            var j = -1;
            var k = 1;
            for (var i = 3; i < max; i++)
            {
                var r = j + k;
                yield return r;

                j = k;
                k = r;

            }
        }

        public static bool IsFibonacciNumber(int number)
        {
            // formular is 5(x * x) + 4 or 5(x * x) - 4 is a perfect square
            var answer = Math.Sqrt((5 * number * number) - 4);
            var result = Math.Floor(answer) == answer;
            if (!result)
            {
                var secondTryAnswer = Math.Sqrt((5 * number * number) + 4);
                result = Math.Floor(secondTryAnswer) == secondTryAnswer;
            }
            return result;
        }
    }
}
