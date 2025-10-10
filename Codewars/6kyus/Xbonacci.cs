namespace Codewars._6kyus;

// https://www.codewars.com/kata/556e0fccc392c527f20000c5

public class Xbonacci
{
    public double[] Solve(double[] signature, int n)
    {
        // examples
        // {1,1,1,1}       10 => {1,1,1,1,4,7,13,25,49,94}
        // {0,0,0,0,1}     10 => {0,0,0,0,1,1,2,4,8,16}
        // {1,0,0,0,0,0,1} 10 => {1,0,0,0,0,0,1,2,3,6}

        double[] result = new double[n];
        int count = signature.Length;

        for (int i = 0; i < n; i++)
        {
            // include signature
            if (i < count)
            {
                result[i] = signature[i];
            }
            // calculate the following elements
            else
            {
                for (int x = i - count; x < i; x++)
                    result[i] += result[x];
            }
        }

        return result;

        // linq
        // var sequence = new List<double>(signature);
        // int count = signature.Length;
        // for (int i = 0; i < n; i++)
        //     sequence.Add(sequence.Skip(i - count).Take(count).Sum());
        //
        // return sequence.Take(n).ToArray();
    }
}
