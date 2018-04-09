namespace KataTests.Helpers
{
    public interface IPassPhraseHelper
    {
        string ReverseString(string s);

        string ReplaceNumbersWith9Equivalent(string s);

        string ShiftLettersByNumber(string s, int n);

        string LowerCaseEvenUppercaseOdd(string s);

        bool IsOdd(int n);
    }
}