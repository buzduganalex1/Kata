using System;

namespace KataTests.Helpers
{
    public class PassPhraseHelper : IPassPhraseHelper
    {
        public string ReverseString(string s)
        {
            var charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }

        public string ReplaceNumbersWith9Equivalent(string s)
        {
            var phrase = string.Empty;

            foreach (char character in s)
            {
                if (char.IsNumber(character))
                {
                    phrase += 9 - char.GetNumericValue(character);
                }
                else
                {
                    phrase += Convert.ToChar(character);
                }
            }

            return phrase;
        }

        public string ShiftLettersByNumber(string s, int n)
        {
            var phrase = string.Empty;

            foreach (var character in s)
            {
                if (!char.IsLetter(character))
                {
                    phrase += character;

                    continue;
                }

                var value = (char)(character + n);

                if (char.IsLetter(value) && char.IsUpper(character) == char.IsUpper(value))
                {
                    phrase += value;
                }
                else
                {
                    phrase += Convert.ToChar(value - 26);
                }
            }

            return phrase;
        }

        public string LowerCaseEvenUppercaseOdd(string s)
        {
            var phrase = string.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                phrase += IsOdd(i) ? char.ToUpper(s[i]) : char.ToLower(s[i]);
            }

            return phrase;
        }

        public bool IsOdd(int n)
        {
            return n % 2 == 0;
        }
    }
}