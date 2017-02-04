using System;
using System.Collections.Generic;
using System.Linq;

namespace NextBiggerNumberKata
{
    public class Kata
    {
        internal int NextBiggerNumber(int input)
        {
            var allNumber = FindAllPermutationNumber(input);
            allNumber = allNumber.Distinct().OrderBy(n => n).ToList();

            int index = allNumber.IndexOf(input);
            if (index == allNumber.Count - 1) return -1;

            return allNumber[index + 1];
        }

        private List<int> FindAllPermutationNumber(int input)
        {
            Permutation permutation = new Permutation();
            var inputChars = input.ToString().ToCharArray().Select(c => c.ToString()).ToList();
            var resultChars = permutation.GetResult(inputChars);

            var length = inputChars.Count;
            List<int> result = new List<int>();
            resultChars.ForEach(digits => {
                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += ((int)Math.Pow(10, i)) * Convert.ToInt16(digits[i]);
                }
                result.Add(sum);
            });
            return result;
        }
    }
}
