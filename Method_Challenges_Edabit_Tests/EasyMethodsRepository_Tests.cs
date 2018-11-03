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
    }
}
