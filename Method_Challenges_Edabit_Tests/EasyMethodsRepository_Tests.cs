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
    }
}
