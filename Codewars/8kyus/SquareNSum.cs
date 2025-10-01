namespace Codewars._8kyus;

public class SquareNSum
{
    public static int SquareSum(int[] numbers)
    {
        // return numbers.Select(x => x * x).Sum();
        // return numbers.Sum(x => x * x);

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
            sum += numbers[i] * numbers[i];

        return sum;
    }
}
