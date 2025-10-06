namespace Codewars._6kyus;

// https://www.codewars.com/kata/5613d06cee1e7da6d5000055

public class StepInPrimes
{
    public static long[]? Step(int g, long m, long n)
    {
        for (long i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                for (long x = i + 1; x <= i + g && x <= n; x++)
                {
                    if (IsPrime(x) && x - i == g)
                        return [i, x];
                }
            }
        }

        return null;
    }

    public static bool IsPrime(long num)
    {
        long limit = (long)Math.Sqrt(num);

        for (long i = 2; i <= limit; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
