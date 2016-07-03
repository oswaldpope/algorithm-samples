using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Recursion
{
    public class StringPermutations
    {
        public IEnumerable<string> PrintAllPermutationsOfString(string input)
        {
            return Permutate(input.ToArray(), 0, input.Length - 1);
        }

        private IEnumerable<string> Permutate(char[] input, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                yield return string.Concat(input);
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    var hold = input[startIndex];
                    input[startIndex] = input[i];
                    input[i] = hold;
                    foreach (var item in Permutate(input, startIndex + 1, endIndex))
                    {
                        yield return item;
                    }
                    hold = input[i];
                    input[i] = input[startIndex];
                    input[startIndex] = hold;
                }
            }
        }
    }
}
