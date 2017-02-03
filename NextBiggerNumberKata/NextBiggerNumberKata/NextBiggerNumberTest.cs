using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace NextBiggerNumberKata
{
    [TestClass]
    public class NextBiggerNumberTest
    {
        [TestMethod]
        public void NextBiggerNumber_input_12_should_be_21()
        {
            // arrange
            var input = 12;
            var expected = 21;

            // act
            var actual = Kata.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_9_should_be_minus_1()
        {
            // arrange
            var input = 9;
            var expected = -1;

            // act
            var actual = Kata.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Kata.NextBiggerNumber(111)==-1
        //Kata.NextBiggerNumber(531)==-1
        //Assert.AreEqual(531, Kata.NextBiggerNumber(513));
        //Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
        //Assert.AreEqual(441, Kata.NextBiggerNumber(414));
        //Assert.AreEqual(414, Kata.NextBiggerNumber(144));
    }

    internal class Kata
    {
        internal static int NextBiggerNumber(int input)
        {
            var inputChars = input.ToString().ToCharArray();
            inputChars = inputChars.Reverse().ToArray();
            var result = Int32.Parse(string.Join("", inputChars));
            if(input == result)
            {
                return -1;
            }
            return result;
        }
    }
}
