namespace Codewars._6kyus;

// https://www.codewars.com/kata/5a3f2925b6cfd78fb0000040

public class SimpleRevesedParenthesis
{
    public static int solve(string s)
    {
        // 1. check for an odd number of parentheses
        // to pair up all parentheses the string must have an even length
        if (s.Length % 2 != 0)
            return -1;

        // 2. remove all correctly matched pairs
        while (s.Contains("()"))
            s = s.Replace("()", string.Empty);

        // 3. count the flips on the remaining string
        // atep, the remaining string will consist of groups of identical parentheses
        // (( or )) or mismatched pairs ")("
        int i = 0;
        int count = 0;

        while (i < s.Length - 1)
        {
            count += s[i] == s[i + 1] ? 1 : 2;
            i += 2;
        }

        return count;
    }
}
