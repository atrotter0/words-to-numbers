using System;
using System.Collections.Generic;

namespace NumberGame
{
    public class NumbersToWords
    {
        private int _userNumber;
        private Dictionary<int, string> _onesDictionary = new Dictionary<int, string>() {};
        private Dictionary<int, string> _tensDictionary = new Dictionary<int, string>() {};
        private Dictionary<int, string> _teensDictionary = new Dictionary<int, string>() {};
        private Dictionary<int, string> _modifierDictionary = new Dictionary<int, string>() {};

        public void SetUserNumber(string number)
        {
            int intNumber = int.Parse(number);
            _userNumber = intNumber;
        }

        public int GetUserNumber()
        {
            return _userNumber;
        }

        public void CreateOnesDictionary()
        {
            _onesDictionary[1] = "one";
            _onesDictionary[2] = "two";
            _onesDictionary[3] = "three";
            _onesDictionary[4] = "four";
            _onesDictionary[5] = "five";
            _onesDictionary[6] = "six";
            _onesDictionary[7] = "seven";
            _onesDictionary[8] = "eight";
            _onesDictionary[9] = "nine";
        }

        public string GetOnesValue(int number)
        {
            return _onesDictionary[number];
        }

        public void CreateTensDictionary()
        {
            _tensDictionary[1] = "ten";
            _tensDictionary[2] = "twenty";
            _tensDictionary[3] = "thirty";
            _tensDictionary[4] = "forty";
            _tensDictionary[5] = "fifty";
            _tensDictionary[6] = "sixty";
            _tensDictionary[7] = "seventy";
            _tensDictionary[8] = "eighty";
            _tensDictionary[9] = "ninety";
        }

        public string GetTensValue(int number)
        {
            return _tensDictionary[number];
        }

        public void CreateTeensDictionary()
        {
            _teensDictionary[1] = "eleven";
            _teensDictionary[2] = "twelve";
            _teensDictionary[3] = "thirteen";
            _teensDictionary[4] = "fourteen";
            _teensDictionary[5] = "fifteen";
            _teensDictionary[6] = "sixteen";
            _teensDictionary[7] = "seventeen";
            _teensDictionary[8] = "eighteen";
            _teensDictionary[9] = "nineteen";
        }

        public string GetTeensValue(int number)
        {
            return _teensDictionary[number];
        }

        public void CreateModifierDictionary()
        {
            _modifierDictionary[13] = "trillion";
            _modifierDictionary[12] = "billion";
            _modifierDictionary[11] = "billion";
            _modifierDictionary[10] = "billion";
            _modifierDictionary[9] = "million";
            _modifierDictionary[8] = "million";
            _modifierDictionary[7] = "million";
            _modifierDictionary[6] = "thousand";
            _modifierDictionary[5] = "thousand";
            _modifierDictionary[4] = "thousand";
        }

        public string GetModifierValue(int number)
        {
            return _modifierDictionary[number];
        }
    }
}
