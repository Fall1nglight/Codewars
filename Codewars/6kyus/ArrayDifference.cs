namespace Codewars._6kyus;

// https://www.codewars.com/kata/523f5d21c841566fde000009

public class ArrayDifference
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> result = new List<int>();
        HashSet<int> set = new HashSet<int>(b);

        for (int i = 0; i < a.Length; i++)
        {
            // Complexity O(n)
            if (!b.Contains(a[i])) { }

            // complexity O(1)
            if (set.Contains(a[i]))
                continue;

            result.Add(a[i]);
        }

        // Linq
        // return a.Where(s => !set.Contains(s)).ToArray();

        return result.ToArray();
    }
}
