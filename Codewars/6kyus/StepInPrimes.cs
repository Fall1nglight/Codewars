namespace Codewars._6kyus;

// https://www.codewars.com/kata/5613d06cee1e7da6d5000055

public class StepInPrimes
{
    public static long[]? Step(int g, long m, long n)
    {
        // old solution
        // for (long i = m; i <= n; i++)
        // {
        //     if (IsPrime(i))
        //     {
        //         for (long x = i + 1; x <= i + g && x <= n; x++)
        //         {
        //             if (IsPrime(x) && x - i == g)
        //                 return [i, x];
        //         }
        //     }
        // }

        // more efficient solution
        // 1. Iterate the Search Range: We iterate through the range from m (lower limit) to n (upper limit), one by one.
        // 2. Check for First Prime: Check if the current number (i) is prime.
        //      If NOT prime → move to the next number.
        //      If IT IS prime → proceed with the iteration.
        // 3. Calculate Second Number: Calculate the potential second number (x) in the pair by adding the step size (g): x=i+g.
        // 4. Check Second Prime: Verify if the calculated value (x) is a prime and does not exceed the upper limit (n).
        // 5. Result/Continuation: If the check is successful, immediately return the first found pair. If not, move to the next iteration of the loop.
        // 6. Failure to Find: If the iteration is complete and no valid pair has been found, return null.
        for (long i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                long x = i + g;

                if (IsPrime(x) && x <= n)
                    return [i, x];
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
