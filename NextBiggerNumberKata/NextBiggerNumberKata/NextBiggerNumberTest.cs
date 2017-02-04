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
    }
}
