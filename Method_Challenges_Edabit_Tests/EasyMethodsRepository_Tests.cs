using System;
using Method_Challenges_EdaBit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Method_Challenges_Edabit_Tests
{
    [TestClass]
    public class EasyMethodsRepository_Tests
    {
        EasyMethodsRepository _easyRepo = new EasyMethodsRepository();

        [TestInitialize]
        public void Arrange()
        {

        }

        [TestMethod]
        public void FirstChallenge_ReturnTrueBool_BoolShouldBeTrue()
        {
            //--Arrange
            bool expected = true;
            //--Act
            bool actual = _easyRepo.ReturnTrue();
            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SecondChallenge_ReturnSumOfTwoInts_IntsShouldBeEqual()
        {
            //--Arrange
            int expected = 9;
            int expectedOne = 25;
            int expectedTwo = 60;

            //--Act
            int actual = _easyRepo.Sum(4, 5);
            int actualOne = _easyRepo.Sum(10, 15);
            int actualTwo = _easyRepo.Sum(30, 30);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void ThirdChallenge_NumberLessThanOrEqualToZero_BoolShouldBeEqual()
        {
            //--Arrange
            bool expected = true;
            bool expectedOne = false;
            bool expectedTwo = true;

            //--Act
            bool actual = _easyRepo.LessThanOrEqualToZero(-10d);
            bool actualOne = _easyRepo.LessThanOrEqualToZero(45d);
            bool actualTwo = _easyRepo.LessThanOrEqualToZero(0d);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void FourthChallenge_IntCheckIfChristmasEve_BoolShouldBeEqual()
        {
            //--Arrange
            bool expected = true;
            bool expectedOne = false;
            bool expectedTwo = false;

            //--Act
            bool actual = _easyRepo.IsItChristmasEve(1994, 12, 24);
            bool actualOne = _easyRepo.IsItChristmasEve(1994, 12, 23);
            bool actualTwo = _easyRepo.IsItChristmasEve(2005, 12, 25);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void FifthChallenge_EvenOrOdd_StringShouldBeTheSame()
        {
            //--Arrange
            string expected = "even";
            string expectedOne = "odd";
            string expectedTwo = "even";

            //--Act
            string actual = _easyRepo.EvenOrOdd(1994);
            string actualOne = _easyRepo.EvenOrOdd(23);
            string actualTwo = _easyRepo.EvenOrOdd(2006);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void SixthChallenge_GetLastItem_ObjectShouldBeTheSame()
        {
            //--Arrange
            object[] array = { "what", "hmmmm...", "hello" };
            object[] arrayOne = { 3, 10, 25, 30, 25, 18, 25 };
            object[] arrayTwo = { false, false, true, false, true };
            object expected = "hello";
            object expectedOne = 25;
            object expectedTwo = true;

            //--Act
            object actual = _easyRepo.GetLastItem(array);
            object actualOne = _easyRepo.GetLastItem(arrayOne);
            object actualTwo = _easyRepo.GetLastItem(arrayTwo);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void SeventhChallenge_LargestIntInArray_IntShouldBeTheSame()
        {
            //--Arrange
            int[] array = { 1, 5, 55, 983 };
            int[] arrayOne = { 3, 10, 25, 30, 25, 18, 25 };
            int[] arrayTwo = { 10, 15, 10000, 1, 100003 };
            int expected = 983;
            int expectedOne = 30;
            int expectedTwo = 100003;

            //--Act
            int actual = _easyRepo.FindLargestNumber(array);
            int actualOne = _easyRepo.FindLargestNumber(arrayOne);
            int actualTwo = _easyRepo.FindLargestNumber(arrayTwo);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void EighthChallenge_SmallestIntInArray_IntShouldBeTheSame()
        {
            //--Arrange
            double[] array = { 1, 5, 55, 983 };
            double[] arrayOne = { 3, 10, 25, 30, 25, 18, 25 };
            double[] arrayTwo = { 10, 15, 10000, 1, 100003 };
            double expected = 1;
            double expectedOne = 3;
            double expectedTwo = 1;

            //--Act
            double actual = _easyRepo.FindSmallestNumber(array);
            double actualOne = _easyRepo.FindSmallestNumber(arrayOne);
            double actualTwo = _easyRepo.FindSmallestNumber(arrayTwo);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void NinthChallenge_CheckEndingOfString_BoolValueShouldComeBackTrueOrFalseBasedOnStrings()
        {
            //--Arrange
            string one = "sir";
            string two = "r";
            string three = "what is your name gentleman marlin fish";
            string four = "what";
            bool expected = true;
            bool expectedOne = false;

            //--Act
            bool actual = _easyRepo.CheckEnding(one, two);
            bool actualOne = _easyRepo.CheckEnding(three, four);

            //--Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
        }

        [TestMethod]
        public void TenthChallenge_CheckEndingOfString_BoolValueShouldComeBackTrueOrFalseBasedOnStrings()
        {
            //--Arrange
            string main = "what is your name gentleman marlin fish";
            string head = "what is";
            string body = "your name gentleman";
            string tail = "marlin fish";
            string expected = "My head, body, and tail.";

            //--Act
            string actual = _easyRepo.VerifySubStrings(main, head, body, tail);

            //--Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
