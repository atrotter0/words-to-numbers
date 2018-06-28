using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberGame;

namespace NumberGame.Tests
{
    [TestClass]
    public class NumbersToWordsTest
    {
        [TestMethod]
        public void SetGetUserNumber_SetsGetsUserNumber_Int()
        {
            NumbersToWords newObject = new NumbersToWords();
            newObject.SetUserNumber("1");
            Assert.AreEqual(1, newObject.GetUserNumber());
        }
    }
}
