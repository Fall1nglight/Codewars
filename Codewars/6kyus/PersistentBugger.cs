namespace Codewars._6kyus;

// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec

public class PersistentBugger
{
    public static int Persistence(long n)
    {
        // 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit, there are 3 multiplications)
        // 999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2, there are 4 multiplications)
        // 4 --> 0 (because 4 is already a one-digit number, there is no multiplication)

        int result = 0;

        while (n >= 10)
        {
            n = n.ToString().Aggregate(1, (sum, num) => sum * (int)char.GetNumericValue(num));
            result++;
        }

        return result;
    }
}
