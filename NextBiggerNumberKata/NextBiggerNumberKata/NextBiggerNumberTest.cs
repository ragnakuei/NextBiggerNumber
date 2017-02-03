﻿using System;
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

        [TestMethod]
        public void NextBiggerNumber_input_111_should_be_minus_1()
        {
            // arrange
            var input = 111;
            var expected = -1;

            // act
            var actual = Kata.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NextBiggerNumber_input_513_should_be_531()
        {
            // arrange
            var input = 513;
            var expected = 531;

            // act
            var actual = Kata.NextBiggerNumber(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //Kata.NextBiggerNumber(531)==-1
        //Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
        //Assert.AreEqual(441, Kata.NextBiggerNumber(414));
        //Assert.AreEqual(414, Kata.NextBiggerNumber(144));
    }

    internal class Kata
    {
        internal static int NextBiggerNumber(int input)
        {
            int multiplier = 100;
            int rightSide = input % multiplier;
            int leftSide = input / multiplier;
            int result = -1;
            if (HasBiggerNumber(rightSide, out result))
            {
                result = leftSide * multiplier + result;
            }
            return result;
        }

        private static bool HasBiggerNumber(int input, out int result)
        {
            var inputChars = input.ToString().ToCharArray();
            inputChars = inputChars.Reverse().ToArray();
            result = Int32.Parse(string.Join("", inputChars));
            if (result > input)
            {
                return true;
            }
            result = -1;
            return false;
        }
    }
}
