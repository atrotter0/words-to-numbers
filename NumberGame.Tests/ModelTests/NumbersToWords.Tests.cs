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
            Assert.AreEqual("1", newObject.GetUserNumber());
        }

        [TestMethod]
        public void GetIncrementNumberCounter_GetsIncrementsNumberCounter_Int()
        {
            NumbersToWords newObject = new NumbersToWords();
            newObject.IncrementNumberCounter();
            Assert.AreEqual(1, newObject.GetNumberCounter());
        }

        [TestMethod]
        public void ResetNumberCounter_ResetsIncrementsNumberCounter_Int()
        {
            NumbersToWords newObject = new NumbersToWords();
            newObject.IncrementNumberCounter();
            newObject.ResetNumberCounter();
            Assert.AreEqual(0, newObject.GetNumberCounter());
        }

        [TestMethod]
        public void SetGetChunksOfThreeNumbers_SetsAndGetsChunksOfThreeNumbers_List()
        {
            NumbersToWords newObject = new NumbersToWords();
            List<char> numbers = new List<char>() { '1', '2', '3' };
            List<List<char>> listOfNumbers = new List<List<char>>() {numbers};
            newObject.AddChunksOfNumbers(numbers);
            CollectionAssert.AreEqual(listOfNumbers, newObject.GetChunksOfThreeNumbers());
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

        [TestMethod]
        public void InputToChars_CreateCharsFromUserInput_Char()
        {
            NumbersToWords newObject = new NumbersToWords();
            newObject.SetUserNumber("123");
            char[] numbersSplit = { '1', '2', '3'};
            CollectionAssert.AreEqual(numbersSplit, newObject.InputToChars());
        }
    }
}
