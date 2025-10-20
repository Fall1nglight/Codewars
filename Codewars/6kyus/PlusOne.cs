using System.Numerics;

namespace Codewars._6kyus;

// https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9

public class PlusOne
{
    public static int[]? UpArray(int[]? num)
    {
        if (num == null || num.Length == 0 || num.Any(n => n < 0 || n >= 10))
            return null;

        string numStr = string.Empty;

        foreach (int i in num)
            numStr += i;

        string sumStr = (BigInteger.Parse(numStr) + 1).ToString();

        if (sumStr.Length < numStr.Length)
            sumStr = new string('0', numStr.Length - sumStr.Length) + sumStr;

        int[] result = new int[sumStr.Length];

        for (int i = 0; i < result.Length; i++)
            result[i] = sumStr[i] - '0';

        return result;
    }
}
