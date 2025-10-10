namespace Codewars._6kyus;

// https://www.codewars.com/kata/559536379512a64472000053

public class Passphrases
{
    public static string playPass(string s, int n)
    {
        char[] result = new char[s.Length];

        // iterate over s
        for (int i = 0; i < s.Length; i++)
        {
            // check if the current character is a letter
            if (char.IsLetter(s[i]))
            {
                // shift current letter by n
                // (circular shift)
                char shifted = (char)('A' + (s[i] - 'A' + n) % 26);

                // downcase each letter in odd position, upcase each letter in even position
                result[i] = i % 2 == 0 ? char.ToUpper(shifted) : char.ToLower(shifted);
            }
            else if (char.IsDigit(s[i]))
            {
                // replace each digit by its complement to 9
                result[i] = (char)('0' + (9 - (s[i] - '0')));
            }
            else
            {
                // handle special characters
                result[i] = s[i];
            }
        }

        // reverse the whole result
        Array.Reverse(result);

        return new string(result);
    }
}
