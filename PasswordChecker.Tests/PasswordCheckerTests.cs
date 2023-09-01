using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordChecker.Tests
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void GetPasswordStrenght_NullField_0Point()
        {
            string password = null;
            int expected = 0;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
        [TestMethod]
        public void GetPasswordStrenght_OnlyNumbersLessThan8Chars_1Point()
        {
            string password = "1";
            int expected = 1;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
        [TestMethod]
        public void GetPasswordStrenght_OnlyNumbersMoreThan7Chars_2Point()
        {
            string password = "1312341234124987";
            int expected = 2;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
        [TestMethod]
        public void GetPasswordStrenght_NumbersAndLowerLettersMoreThan7Chars_3Point()
        {
            string password = "132412348oy7adsf";
            int expected = 3;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
        [TestMethod]
        public void GetPasswordStrenght_NumbersAndAllLettersMoreThan7Chars_4Point()
        {
            string password = "1234KJHasdLasdf4123";
            int expected = 4;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
        [TestMethod]
        public void GetPasswordStrenght_AllCharsMoreThan7Chars_5Point()
        {
            string password = "!123QWEqwe";
            int expected = 5;

            PasswordChecker checker = new PasswordChecker();
            int actual = checker.CheckPassword(password);

            Assert.AreEqual(expected, actual );
        }
    }
}
