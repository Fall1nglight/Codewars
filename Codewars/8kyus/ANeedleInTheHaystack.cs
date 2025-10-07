namespace Codewars._8kyus;

// https://www.codewars.com/kata/56676e8fabd2d1ff3000000c

public class ANeedleInTheHaystack
{
    public static string FindNeedle(object[] haystack)
    {
        // 1. we iterate through the haystack till we find the string "needle"
        // 2. return the index+1 as result

        int i = 0;
        while (i < haystack.Length)
        {
            if (haystack[i] is string && ((string)haystack[i]).Equals("needle"))
                break;
            i++;
        }

        return $"found the needle at position {i}";

        // shorter version
        return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
    }
}
