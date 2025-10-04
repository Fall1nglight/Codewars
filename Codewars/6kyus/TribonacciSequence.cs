namespace Codewars._6kyus;

public class TribonacciSequence
{
    public double[] Tribonacci(double[] signature, int n)
    {
        if (n == 0)
            return [];

        double[] result = new double[n];

        for (int i = 0; i < n; i++)
        {
            if (i < 3)
                result[i] = signature[i];
            else
                result[i] = result[i - 3] + result[i - 2] + result[i - 1];
        }

        return result;

        // double[] result = new double[n < 4 ? 3 + n : n];
        //
        // result[0] = signature[0];
        // result[1] = signature[1];
        // result[2] = signature[2];
        //
        // for (int i = 3; i < n; i++)
        //     result[i] = result[i - 1] + result[i - 2] + result[i - 3];
        //
        // Array.Resize(ref result, n);
        // return result;
    }
}
