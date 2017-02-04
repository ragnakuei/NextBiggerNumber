using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

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
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_9_should_be_minus_1()
        {
            // arrange
            var input = 9;
            var expected = -1;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_111_should_be_minus_1()
        {
            // arrange
            var input = 111;
            var expected = -1;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_513_should_be_531()
        {
            // arrange
            var input = 513;
            var expected = 531;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_531_should_be_minus_1()
        {
            // arrange
            var input = 531;
            var expected = -1;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_2017_should_be_2071()
        {
            // arrange
            var input = 2017;
            var expected = 2071;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_414_should_be_441()
        {
            // arrange
            var input = 414;
            var expected = 441;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_144_should_be_414()
        {
            // arrange
            var input = 144;
            var expected = 414;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_4321_should_be_minus_1()
        {
            // arrange
            var input = 4321;
            var expected = -1;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_4312_should_be_4321()
        {
            // arrange
            var input = 4312;
            var expected = 4321;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_4231_should_be_4312()
        {
            // arrange
            var input = 4231;
            var expected = 4312;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_15963_should_be_16359()
        {
            // arrange
            var input = 15963;
            var expected = 16359;
            var target = new Kata();

            // act
            var actual = target.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        internal int NextBiggerNumber(int input)
        {
            var inputChars = input.ToString().ToCharArray().ToList();
            for (int i = inputChars.Count - 2; i >= 0; i--)
            {
                if (inputChars[i] >= inputChars[i + 1]) continue;

                var resultLeftSide = inputChars.Take(i);
                var tempRightSide = inputChars.Skip(i).ToList();
                tempRightSide.Remove(inputChars[i + 1]);

                var resultRightSide = new List<char> { inputChars[i + 1] };
                resultRightSide = resultRightSide.Concat(tempRightSide.OrderBy(c => c)).ToList();
                
                return Convert.ToInt32(string.Join("", resultLeftSide.Concat(resultRightSide)));
            }
            return -1;
        }
    }
}
