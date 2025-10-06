namespace Codewars._6kyus;

// https://www.codewars.com/kata/550498447451fbbd7600041c

public class AreTheySame
{
    public static bool comp(int[]? a, int[]? b)
    {
        // We are given two integer arrays, 'a' and 'b'.
        // The function must determine if every element in 'b' is the square of a corresponding element in 'a',
        // maintaining the same multiplicity (frequency of occurrence), regardless of order.
        // If 'a' or 'b' is null or an empty array ([]), the function should return **false**.

        // A naive (inefficient) approach would be to iterate over array 'b',
        // calculate the square root of each item, and then search for that square root within array 'a'.
        // Since checking for the presence of each element in 'a' involves another loop,
        // this leads to an inefficient time complexity of O(n^2)

        // A better approach is to sort both the 'a' and 'b' arrays.
        // Sorting ensures that if the arrays are "the same" (one is the squares of the other with equal multiplicity),
        // then the sorted i-th element of 'b' must equal the square of the sorted i-th element of 'a'.
        // We then iterate through both arrays simultaneously (by index) and check the condition a[i] * a[i] == b[i].
        // If this condition fails, we return **false**. This approach has a more efficient time complexity of O(N log N) due to the sorting step.

        if (a == null || b == null || a.Length != b.Length)
            return false;

        Array.Sort(a);
        Array.Sort(b);

        int i = 0;

        while (i < a.Length && i < b.Length && a[i] * a[i] == b[i])
            i++;

        return i == a.Length;

        // LINQ
        // return a.Select(x => x*x).OrderBy(x=>x).SequenceEqual(b.OrderBy(x=>x));
    }
}
