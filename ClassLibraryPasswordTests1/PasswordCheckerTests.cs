using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //arrange.
            string password = "password";
            bool expected = true;

            //act
            bool actual = PasswordChecker.ValidatePassword(password);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            //arrange.
            string password = "123456";

            //act
            bool actual = PasswordChecker.ValidatePassword(password);

            //assert
            Assert.IsFalse(actual);
        }
    }
}