using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBiggerNumberKata
{
    public class Kata
    {
        internal int NextBiggerNumber(int input)
        {
            int length = input.ToString().ToCharArray().Count();
            int lengthCount = 2;
            int result = -1;
            while (lengthCount <= length)
            {
                int multiplier = (int)Math.Pow(10, length);
                int rightSide = input % multiplier;
                int leftSide = input / multiplier;
                if (HasBiggerNumber(rightSide, out result))
                {
                    result = leftSide * multiplier + result;
                    break;
                }
                lengthCount++;
            }
            return result;
        }

        private bool HasBiggerNumber(int input, out int result)
        {
            var allNumber = FindAllPermutationNumber(input);
            allNumber = allNumber.Distinct().OrderBy( n => n).ToList();
            if(allNumber.Count == 1)
            {
                result = -1;
                return false;
            }

            int index = allNumber.IndexOf(input);
            if (index == allNumber.Count-1)
            {
                result = -1;
                return false;
            }
            result = allNumber[index + 1];
            return true;
        }

        private List<int> FindAllPermutationNumber(int input)
        {
            Permutation permutation = new Permutation();
            var inputChars = input.ToString().ToCharArray().Select(c=> c.ToString()).ToList();
            var resultChars = permutation.GetResult(inputChars);

            var length = inputChars.Count;
            List<int> result = new List<int>();
            resultChars.ForEach( digits => {
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
