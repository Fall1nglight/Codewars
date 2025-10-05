namespace Codewars._6kyus;

// https://www.codewars.com/kata/54e6533c92449cc251001667

public class UniqueInOrder
{
    public static IEnumerable<T> UniqueInOrderFn<T>(IEnumerable<T> iterable)
    {
        // 1. convert the enumerable object into a list to allow index-based traversal
        // 2. uterate through the list using a counter loop from index 0 to n
        // 3. use an inner while loop to find the end of the current run of identical elements
        // 4. add the current element (the start of the run) to the result list
        // 5. update the outer loop index (i) to jump past the elements processed by the inner loop, ensuring O(n) complexity
        // 6. return the result

        List<T> result = new List<T>();
        List<T> items = iterable.ToList();

        for (int i = 0; i < items.Count; i++)
        {
            result.Add(items[i]);
            int x = i + 1;

            while (x < items.Count && items[i].Equals(items[x]))
                x++;

            i = x - 1;
        }

        return result;
    }
}
