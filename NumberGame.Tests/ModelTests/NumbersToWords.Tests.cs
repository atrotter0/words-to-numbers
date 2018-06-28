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

        [TestMethod]
        public void CreateDictionaries_CreatesAllDictionaries_String()
        {
            NumbersToWords newObject = new NumbersToWords();
            newObject.CreateOnesDictionary();
            newObject.CreateTensDictionary();
            newObject.CreateTeensDictionary();
            newObject.CreateModifierDictionary();
            Assert.AreEqual("one", newObject.GetOnesValue(1));
            Assert.AreEqual("thirteen", newObject.GetTeensValue(3));
            Assert.AreEqual("forty", newObject.GetTensValue(4));
            Assert.AreEqual("million", newObject.GetModifierValue(7));
        }
    }
}
