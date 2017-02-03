using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        //Assert.AreEqual(531, Kata.NextBiggerNumber(513));
        //Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
        //Assert.AreEqual(441, Kata.NextBiggerNumber(414));
        //Assert.AreEqual(414, Kata.NextBiggerNumber(144));
    }

    internal class Kata
    {
        internal static int NextBiggerNumber(int input)
        {
            throw new NotImplementedException();
        }
    }
}
